import { ChakraProvider } from "@chakra-ui/react";
import dynamic from "next/dynamic";

const AnonLayout = dynamic(() => import("@/layouts/Anon/layout"));
const AdminLayout = dynamic(() => import("@/layouts/Admin/layout"));
const ErrorLayout = dynamic(() => import("@/layouts/Error/layout"));
const PlaceholderLayout = dynamic(() =>
  import("@/layouts/PlaceholderLayout/layout")
);

import theme from "../src/theme";
import "../styles/globals.css";
import AOS from "aos";
import "aos/dist/aos.css";
import { useRouter } from "next/router";
import { useEffect } from "react";

function MyApp({ Component, pageProps, session, statusCode }) {
  const router = useRouter();
  
  const routeLayoutMap = {
    "/": AnonLayout,
    "/admin": AdminLayout,
    "/login": PlaceholderLayout,
    "/register": PlaceholderLayout,
    "/docs": PlaceholderLayout,
    "/api-docs": PlaceholderLayout,
  };

  let Layout = [401, 403, 404, 500, 501].includes(statusCode)
    ? ErrorLayout
    : routeLayoutMap[router.pathname] || AnonLayout;

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

      <></>
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
