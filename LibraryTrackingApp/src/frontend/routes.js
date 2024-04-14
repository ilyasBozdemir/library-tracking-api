const { TR_LOCALE, EN_LOCALE } = require("./lib/locales");
const { i18n } = require("./next-i18next.config");
const { siteInfo } = require("./siteInfo");
siteInfo;
// routes.js

const generateLocaleSource = (locale, path) => {
  return i18n.defaultLocale !== locale ? "/" + locale + path : path;
};

const trRoutes = {
  "/": {
    config: {
      rewrite: {
        source: generateLocaleSource(TR_LOCALE.hl, "/"),
        destination: "/",
        locale: "tr",
      },
      redirect: {},
    },

    //
    meta: {
      title: "Türkçe Başlık",
      description: "Türkçe Açıklama",
      canonical: siteInfo + generateLocaleSource(TR_LOCALE.hl, "/"),
    },
    sitemap: {
      pageName: "pages-sitemap.xml",
      changeFreq: "weekly",
      priority: "1",
    },
  },
  "/about": {
    config: {
      rewrite: {
        source: generateLocaleSource(TR_LOCALE.hl, "/hakkimizda"),
        destination: "/about",
        locale: "tr",
      },
      redirect: {},
    },

    //
    meta: {
      title: "Hakkımızda - Türkçe",
      description: "Hakkımızda ile ilgili Türkçe açıklama",
      canonical: "https://ornek.com/tr/hakkimizda",
    },
    sitemap: {
      pageName: "pages-sitemap.xml",
      changeFreq: "weekly",
      priority: "0.8",
    },
  },
};

const enRoutes = {
  "/": {
    config: {
      rewrite: {
        source: generateLocaleSource(EN_LOCALE.hl, "/"),
        destination: "/",
        locale: "en",
      },
      redirect: {},
    },

    //
    meta: {
      title: "English Title",
      description: "English Description",
      canonical: "https://example.com/en",
    },
    sitemap: {
      pageName: "pages-sitemap.xml",
      changeFreq: "weekly",
      priority: "1",
    },
  },
  "/about": {
    config: {
      rewrite: {
        source: generateLocaleSource(EN_LOCALE.hl, "/about"),
        destination: "/about",
        locale: "en",
      },
      redirect: {},
    },

    //
    meta: {
      title: "About Us in English",
      description: "Description about us in English",
      canonical: "https://example.com/en/about",
    },
    sitemap: {
      pageName: "pages-sitemap.xml",
      changefreq: "monthly",
      priority: 0.7,
    },
  },
};

module.exports = {
  tr: trRoutes,
  en: enRoutes,
};
