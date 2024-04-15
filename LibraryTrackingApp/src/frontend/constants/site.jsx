import theme from "../src/theme";

import { ttCode } from "../lib/ttCode";
import { gtmCode } from "../lib/gtmCode";
import { pinterestAnalyticsCode } from "../lib/pinterestAnalyticsCode";
import { googleAnalyticsCode } from "../lib/googleAnalyticsCode";
import { facebookPixelCode } from "../lib/facebookPixelCode";

const API_BASE_URL =
  process.env.NODE_ENV === "production"
    ? "https://api.appizsoft.com/"
    : "http://localhost:5226";

const baseUrl =
  process.env.NODE_ENV === "production"
    ? "https://appizsoft.com"
    : "http://localhost:3000";

export const site = {
  title: ``,
  API_BASE_URL: API_BASE_URL,
  baseUrl: baseUrl,
  publisher: ``,
  ogImage: "",
  twImage: "",
  logoUrl: baseUrl + "/logo.png",
  imageAlt: "site-logo-png",
  description: ``,
  name: ``,
  keywords: "",
  isRobotIndex: true,
  themeColor: theme.colors.primary,
  lang: "tr",
  mailAddress: "info@domain.com",
  address: {
    streetAddress: ``,
    addressLocality: ``,
    addressRegion: ``,
    postalCode: ``,
    addressCountry: `TR`,
  },
 
  analyticsCodes: {
    pinterestAnalyticsCode,
    googleAnalyticsCode,
    facebookPixelCode,
    gtmCode,
    ttCode,
  },
};
