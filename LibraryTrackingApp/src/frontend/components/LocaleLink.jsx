import Link from "next/link";
import { useRouter } from "next/router";
import React from "react";
const routes = require("@/routes");

const LocaleLink = ({ href, title ,rest}) => {
  const router = useRouter();
  const { locale } = router;
  const currentLanguage = locale;
  const getRouteSource = (href) => {
    return routes[currentLanguage][href].source;
  };


  return (
    <Link href={getRouteSource(href, currentLanguage)} locale={locale} >
      <>{title}</>
    </Link>
  );
};

export default LocaleLink;
