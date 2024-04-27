import { ChakraProvider, extendTheme } from "@chakra-ui/react";
import dynamic from "next/dynamic";

const AnonLayout = dynamic(() => import("@/layouts/Anon/layout"));
const AppLayout = dynamic(() => import("@/layouts/App/layout"));
const AdminLayout = dynamic(() => import("@/layouts/Admin/layout"));
const PlaceholderLayout = dynamic(() =>
  import("@/layouts/Placeholder/layout")
);



import { useColorMode, colorMode } from "@chakra-ui/react";

import "../styles/globals.css";
import AOS from "aos";
import "aos/dist/aos.css";
import { useRouter } from "next/router";
import { useEffect } from "react";
import { darkTheme, lightTheme } from "@/src/foundations/colors";
import { AuthContextProvider, AuthProvider } from "@/contexts/AuthContext";
import { AppContextProvider } from "@/contexts/AppContext";
import { errorStatusCodes } from "@/constants/errorStatusCodes";

function MyApp({ Component, pageProps, session, statusCode }) {
  const router = useRouter();

  const theme = extendTheme(
    colorMode === "light" ? lightTheme.colors : darkTheme.colors
  );

  const placeholderRoutes = ["/login", "/register", "/docs", "/api-docs",'/401','/403','/404','/409','/500','/501','/502','/503'];
  const anonLayoutRoutes = ["/./"];
  const adminLayoutRoutes = /^\/admin(?:\/|$)/;
  const appLayoutRoutes = /^\/app(?:\/|$)/;

  const routeLayoutMap = [
    { regex: adminLayoutRoutes, layout: AdminLayout },
    { regex: appLayoutRoutes, layout: AppLayout },
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
      {errorStatusCodes.includes(statusCode) ? (
        <>
          <PlaceholderLayout statusCode={statusCode} />
        </>
      ) : (
        <AppContextProvider>
          <AuthContextProvider>
            <ChakraProvider theme={theme} resetCSS>
              <Layout>
                <Component {...pageProps} />
              </Layout>
            </ChakraProvider>
          </AuthContextProvider>
        </AppContextProvider>
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
