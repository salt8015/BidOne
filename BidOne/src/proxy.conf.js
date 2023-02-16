const PROXY_CONFIG = [
  {
    context: [
      "/user",
    ],
    target: "https://localhost:7277",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
