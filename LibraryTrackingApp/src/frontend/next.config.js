// next.config.js

const { i18n } = require("./next-i18next.config");
const routes = require("./routes");

const nextConfig = {
  reactStrictMode: true,
  exportTrailingSlash: true,
  exportPathMap: async function (
    defaultPathMap,
    { dev, dir, outDir, distDir, buildId }
  ) {
    return {
      // paths...
    };
  },
  // Zaman aşımını artırın
  exportTrailingSlash: true,
  exportPathMap: async function (
    defaultPathMap,
    { dev, dir, outDir, distDir, buildId }
  ) {
    return {
      // paths...
    };
  },
  // Zaman aşımını artırın
  exportTrailingSlash: true,
  exportPathMap: async function (
    defaultPathMap,
    { dev, dir, outDir, distDir, buildId }
  ) {
    return {
      // paths...
    };
  },
  // Zaman aşımını artırın
  exportTrailingSlash: true,
  exportPathMap: async function (
    defaultPathMap,
    { dev, dir, outDir, distDir, buildId }
  ) {
    return {
      // paths...
    };
  },
  // Zaman aşımını artırın
  exportTimeout: 1000, // 1 saniye yerine başka bir değer de kullanabilirsiniz

};

module.exports = nextConfig;
