FROM python:3.11-slim

# Install system dependencies
RUN apt-get update && apt-get install -y \
    curl \
    git \
    wget \
    unzip \
    && rm -rf /var/lib/apt/lists/*

# Install Node.js for Gemini CLI
RUN curl -fsSL https://deb.nodesource.com/setup_20.x | bash - \
    && apt-get install -y nodejs \
    && rm -rf /var/lib/apt/lists/*

# Install Gemini CLI globally
RUN npm install -g @google/generative-ai-cli

# Verify Gemini CLI installation
RUN gemini --version || echo "Gemini CLI installation check"

# Set working directory
WORKDIR /app

# Copy requirements first for better caching
COPY requirements.txt .
RUN pip install --no-cache-dir -r requirements.txt

# Copy application files
COPY . .

# Create necessary directories
RUN mkdir -p /app/output/json /app/output/csharp /app/output/logs

# Set environment variables
ENV PYTHONUNBUFFERED=1

# The gemini CLI tool should be authenticated on the host machine
# Authentication is handled through the CLI tool's login flow

# Default command
CMD ["python", "orchestrate_gnt_generation.py", "--help"]