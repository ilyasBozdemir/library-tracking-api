import Document, { Html, Head, Main, NextScript } from "next/document";
import {  darkTheme, lightTheme } from "../src/foundations/colors";
import { ColorModeScript, colorMode, extendTheme } from "@chakra-ui/react";
import GoogleTagManagerBody from "../plugins/GoogleTagManagerBody";
import ExternalFonts from "../fonts/ExternalFonts";
import React, { useEffect } from "react";

import { site } from "../constants/site";

export default class MyDocument extends Document {
  render() {
    const { langValue, pageContext } = this.props;
    const officialDomainName = site.baseUrl;

    const theme = extendTheme(
      colorMode === "light" ? lightTheme.colors : darkTheme.colors
    );

    const themeColor = theme.primary[100];

    //const isAnalyticsVisible = AnalyticsIsVisible();

    useEffect(() => {
      console.log(l);
    }, []);

    return (
      <Html lang={langValue || site.lang} prefix="og: http://ogp.me/ns#">
        <Head>
          <meta charSet="utf-8" />

          <meta http-equiv="X-UA-Compatible" content="ie=edge" />
          <meta name="language" content="Turkish" />
          <meta
            name="viewport"
            content="width=device-width,minimum-scale=1,initial-scale=1"
          />

          <meta httpEquiv="Content-Type" content="text/html; charset=utf-8" />
          <meta name="revisit-after" content="1 days" />
          <link rel="icon" href="/favicon.png" type="image/png" />
          <meta name="theme-color" content={themeColor} />

          <ExternalFonts />

          <link href="/styles/globals.css" />
        </Head>
        <body>
          <GoogleTagManagerBody code={site.analyticsCodes.gtmCode} />
          <ColorModeScript initialColorMode={theme.config.initialColorMode} />
          <Main />
          <NextScript />
        </body>
      </Html>
    );
  }
}

MyDocument.getInitialProps = async (ctx) => {
  const originalRenderPage = ctx.renderPage;
  ctx.renderPage = () =>
    originalRenderPage({
      enhanceApp: (App) =>
        function EnhanceApp(props) {
          return <App {...props} />;
        },
    });
  const initialProps = await Document.getInitialProps(ctx);

  const { asPath } = ctx;

  const language = asPath.split("/")[1];
  let langValue = "tr";

  if (language === "tr" || language === "en") {
    langValue = language;
  }

  return {
    ...initialProps,
    langValue,
  };
};
