import locales, { EN_LOCALE, TR_LOCALE } from "@/lib/locales";
import { Box, Button, Select, useColorModeValue } from "@chakra-ui/react";
import { useRouter } from "next/router";
import React, { useEffect, useState } from "react";

const routes = require("../routes");
const getRouteSource = (name, language) => {
  return routes[language][name].source;
};

function LangSwitcher() {
  const router = useRouter();
  const { locale } = router;

  const [currentLocale, setCurrentLocale] = useState(locale);

  useEffect(() => {
    const savedLocale = localStorage.getItem("selectedLocale");
    if (savedLocale) {
      setCurrentLocale(savedLocale);
    }
  }, []);

  let newRoute = ``;

  const toggleLanguage = () => {
    const newLocale =
      currentLocale === EN_LOCALE.hl ? TR_LOCALE.hl : EN_LOCALE.hl;
    setCurrentLocale(newLocale);
    localStorage.setItem("selectedLocale", newLocale);

    newRoute = getRouteSource(router.pathname, newLocale);

    window.history.replaceState({}, "", newRoute);

    if (newRoute) {
      router.push(newRoute, undefined, { locale: newLocale });
    } else {
      router.push(router.pathname, undefined, {
        locale: newLocale,
      });
    }
  };

  return (
    <>
      <Button
        id="lang-switcher"
        color={useColorModeValue("text.200", "textD.200")}
        bg="transparent"
        p={2}
        fontSize="lg"
        onClick={toggleLanguage}
        mr={2}
        variant={"link"}
        _hover={{
          textDecoration: "none",
          color: "primary.100",
        }}
        cursor={"pointer"}
      >
        {currentLocale === EN_LOCALE.hl ? "TR" : "EN"}
      </Button>

      <LanguageSelector />
    </>
  );
}

function LanguageSelector() {
  const languageKeys = Object.keys(locales);
  const [selectedLanguage, setSelectedLanguage] = React.useState(
    languageKeys[0]
  );

  useEffect(() =>
   {}, [selectedLanguage]);

  const handleLanguageChange = (language) => {
    setSelectedLanguage(language);
  };

  return (
    <Box>
      <Select
        value={selectedLanguage}
        onChange={(e) => handleLanguageChange(e.target.value)}
      >
        {languageKeys.map((key) => (
          <option key={key} value={key}>
            {locales[key]?.hl}
          </option>
        ))}
      </Select>
    </Box>
  );
}

export default LangSwitcher;
