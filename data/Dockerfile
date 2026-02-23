FROM python:3.12-slim

WORKDIR /app

# Install dependencies
RUN pip install --no-cache-dir requests lxml tqdm openpyxl

# Copy all scripts into the image
COPY parse_opengnt.py .
COPY parse_oshb.py .
COPY ai_seeding_prompt_greek.py .
COPY ai_seeding_prompt_hebrew.py .
COPY README.md .

# Output goes to /app/build — mount a host volume here to retrieve files
RUN mkdir -p /app/build

# Default: show usage. Override with `docker run ... python parse_opengnt.py --help`
CMD ["python", "--version"]