# Build stage
FROM node:24.13-alpine AS build
WORKDIR /app
COPY  . .
RUN npm install
RUN npm run build

# Run stage
FROM nginx:stable-alpine3.23
COPY default.conf /etc/nginx/conf.d
COPY --from=build /app/dist/WebUI/browser /usr/share/nginx/html
EXPOSE 80
HEALTHCHECK --interval=30s --timeout=3s --retries=3 \
  CMD curl --fail http://localhost:80/healthz || exit 1
CMD ["nginx", "-g", "daemon off;"]
