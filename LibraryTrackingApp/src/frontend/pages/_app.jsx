import { ChakraProvider, extendTheme } from "@chakra-ui/react";
import dynamic from "next/dynamic";

const AnonLayout = dynamic(() => import("@/layouts/Anon/layout"));
const AdminLayout = dynamic(() => import("@/layouts/Admin/layout"));
const ErrorLayout = dynamic(() => import("@/layouts/Error/layout"));
const PlaceholderLayout = dynamic(() =>
  import("@/layouts/PlaceholderLayout/layout")
);

import { useColorMode,colorMode } from "@chakra-ui/react";

import "../styles/globals.css";
import AOS from "aos";
import "aos/dist/aos.css";
import { useRouter } from "next/router";
import { useEffect } from "react";
import { darkTheme, lightTheme } from "@/src/foundations/colors";

function MyApp({ Component, pageProps, session, statusCode }) {
  const router = useRouter();

  const theme = extendTheme(colorMode === "light" ? lightTheme.colors : darkTheme.colors);



  const placeholderRoutes = ["/login", "/register", "/docs", "/api-docs"];
  const anonLayoutRoutes = ["/./"];
  const adminLayoutRoutes = /^\/admin(?:\/|$)/

  const routeLayoutMap = [
    { regex: adminLayoutRoutes, layout: AdminLayout },
    {
      regex: new RegExp(`^(${placeholderRoutes.join("|")})`),
      layout: PlaceholderLayout,
    },
    {
      regex: new RegExp(`^(${anonLayoutRoutes.join("|")})`),
      layout: AnonLayout,
    },
  ];

  let Layout =
    routeLayoutMap.find((route) => router.pathname.match(route.regex))
      ?.layout || AnonLayout;

  useEffect(() => {
    AOS.init({
      duration: 1000,
      once: true,
      easing: "ease-out-back",
    });
    AOS.refresh();
  }, []);

  return (
    <>
      {[401, 403, 404, 500, 501].includes(statusCode) ? (
        <>
          <ErrorLayout statusCode={statusCode} />
        </>
      ) : (
        <>
          <ChakraProvider theme={theme} resetCSS>
            <Layout>
              <Component {...pageProps} />
            </Layout>
          </ChakraProvider>
        </>
      )}
    </>
  );
}

MyApp.getInitialProps = async (appContext) => {
  const { Component, ctx } = appContext;
  let pageProps = {};
  let session = {};

  if (Component.getInitialProps) {
    pageProps = await Component.getInitialProps(ctx);
    session = await Component.getInitialProps(ctx);
  }

  const { res, err } = ctx;
  const statusCode = res ? res.statusCode : err ? err.statusCode : null;

  return { pageProps, session, statusCode };
};

export default MyApp;
