import { socialMediaIcons } from "@/assets/icons";
import {
  navLinks,
  dropdownLinks,
  footerLinks,
  socialMediaLinks,
} from "@/siteInfo";

import formatPhoneNumber from "@/utils/formatPhoneNumber";

const baseUrl =
  process.env.NODE_ENV === "production"
    ? "https://www.production-doamin.com"
    : "http://localhost:3000";

const logoUrl =
  process.env.NODE_ENV === "production" ? "/logo.svg" : "/logo.svg";

const addressInfo = {
  streetAddress: ``,
  addressLocality: ``,
  addressRegion: ``,
  postalCode: ``,
  addressCountry: ``,
};

const initialSiteInfo = {
  baseUrl: baseUrl,
  addressInfo,
  logoUrl: baseUrl + logoUrl,
  phoneNumber: `+905555555555`,
};

initialSiteInfo.phoneNumberDisplay = formatPhoneNumber(
  initialSiteInfo.phoneNumber
);



export {
  navLinks,
  dropdownLinks,
  footerLinks,
  socialMediaLinks,
  initialSiteInfo as default,
};
