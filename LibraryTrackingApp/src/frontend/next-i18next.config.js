const path = require("path");
const {
  TR_LOCALE,
  EN_LOCALE,
  FR_LOCALE,
  ES_LOCALE,
  DE_LOCALE,
  IT_LOCALE,
  AR_LOCALE,
  ZH_LOCALE,
  JA_LOCALE,
} = require("./lib/locales");

module.exports = {
  i18n: {
    locales: [
      EN_LOCALE.hl,
      TR_LOCALE.hl,
      FR_LOCALE.hl,
      ES_LOCALE.hl,
      DE_LOCALE.hl,
      IT_LOCALE.hl,
      AR_LOCALE.hl,
      ZH_LOCALE.hl,
      JA_LOCALE.hl,
    ],
    defaultLocale: TR_LOCALE.hl,
  },
  localePath: path.resolve("./locales"),
};
