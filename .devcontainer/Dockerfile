FROM mcr.microsoft.com/devcontainers/dotnet:2-10.0-noble

# Update packages
RUN export DEBIAN_FRONTEND=noninteractive && apt update && apt upgrade -y && apt autoremove -y

# Set bash aliases
RUN echo "alias cls=clear" >> /home/vscode/.bashrc && \
    echo "alias lah='ls -lah'" >> /home/vscode/.bashrc
