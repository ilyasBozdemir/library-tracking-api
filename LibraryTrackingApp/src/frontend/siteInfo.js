// siteInfo.js

const baseUrl =
  process.env.NODE_ENV === "production"
    ? "https://www.prod-domain.com"
    : "http://localhost:3000";

 const navLinks = [
  { name: "About", path: "#", i18nKey: "navs.about" },
  { name: "Features", path: "#", i18nKey: "navs.features" },
  { name: "Pricing", path: "#", i18nKey: "navs.pricing" },
];
 const dropdownLinks = [
  {
    name: "Blog",
    path: "#",
    i18nKey: "navs.blog",
  },
  {
    name: "Documentation",
    path: "#",
    i18nKey: "navs.documentation",
  },
];

 const footerLinks = [
  { name: "About", path: "#", i18nKey: "navs.about" },
  {
    name: "Documentation",
    path: "#",
    i18nKey: "navs.documentation",
  },
];
const socialMediaLinks = [
  { text: "Facebook", path: "#Facebook", icon: '' },
  { text: "Twitter", path: "#Twitter", icon: ''},
  { text: "Instagram", path: "#Instagram",  icon: '' },
  { text: "Youtube", path: "#Youtube",  icon: '' },
];

 const siteInfo = {
  baseUrl,
  navbarPaths: ["home", "about"],
  footerPaths: ["home", "about"],
  socialMediaLinks,
  sitemaps: [
    { fileName: "/blog-sitemap.xml" },
    { fileName: "/pages-sitemap.xml" },
  ],
};

module.exports = {
  siteInfo,
  navLinks,
  dropdownLinks,
  footerLinks,
  socialMediaLinks
};