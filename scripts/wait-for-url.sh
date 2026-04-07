#!/usr/bin/env bash
set -euo pipefail

url="$1"
timeout_seconds="${2:-60}"
interval_seconds="${3:-2}"

start_time=$(date +%s)

while true; do
  if curl --silent --fail "$url" >/dev/null; then
    exit 0
  fi

  now=$(date +%s)
  elapsed=$((now - start_time))
  if [ "$elapsed" -ge "$timeout_seconds" ]; then
    echo "Timed out waiting for $url after ${timeout_seconds}s" >&2
    exit 1
  fi

  sleep "$interval_seconds"
done
