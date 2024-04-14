import { Box, Button, Select, useColorModeValue } from "@chakra-ui/react";
import { useRouter } from "next/router";
import React, { useEffect, useState } from "react";
import locales, { EN_LOCALE, TR_LOCALE } from "../lib/locales";

const routes = require("../routes");

const getRouteSource = (name, language) => {
  if (routes[language] && routes[language][name]) {
    return routes[language][name].config.rewrite.source;
  }
  return null;
};

function LangSwitcher() {
  const router = useRouter();
  const { locale } = router;
  const broadcastChannel = new BroadcastChannel("lang-switch");

  const [currentLocale, setCurrentLocale] = useState(locale);

  useEffect(() => {
    const savedLocale = localStorage.getItem("selectedLocale") || locale;
    setCurrentLocale(savedLocale);
    broadcastChannel.postMessage(currentLocale);

    broadcastChannel.addEventListener("message", (message) => {
      changeLanguage(message.data);
    });

  }, []);

  const changeLanguage = (newLocale) => {
    setCurrentLocale(newLocale);
    const newRoute = getRouteSource(router.pathname, newLocale);
    if (newRoute) {
      router.push(newRoute, undefined, { locale: newLocale, shallow: true });
    } else {
      router.push(router.pathname, undefined, {
        locale: newLocale,
        shallow: true
      });
    }
  };

  const toggleLanguage = () => {
    const newLocale =
      currentLocale === EN_LOCALE.hl ? TR_LOCALE.hl : EN_LOCALE.hl;
    localStorage.setItem("selectedLocale", newLocale);
    changeLanguage(newLocale);
    broadcastChannel.postMessage(newLocale);
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
    </>
  );
}

export default LangSwitcher;
