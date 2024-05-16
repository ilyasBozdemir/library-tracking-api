import {
  Alert,
  AlertIcon,
  ChakraProvider,
  Text,
  extendTheme,
} from "@chakra-ui/react";
import dynamic from "next/dynamic";

const AnonLayout = dynamic(() => import("@/layouts/Anon/layout"));
const AppLayout = dynamic(() => import("@/layouts/App/layout"));
const MeLayout = dynamic(() => import("@/layouts/Me/layout"));
const AdminLayout = dynamic(() => import("@/layouts/Admin/layout"));
const ForumLayout = dynamic(() => import("@/layouts/Forum/layout"));
const PlaceholderLayout = dynamic(() => import("@/layouts/Placeholder/layout"));

import "../styles/globals.css";
import AOS from "aos";
import "aos/dist/aos.css";
import { useRouter } from "next/router";
import { useEffect, useState } from "react";
import { darkTheme, lightTheme } from "@/src/foundations/colors";
import { AuthContextProvider, AuthProvider } from "@/contexts/AuthContext";
import { AppContextProvider } from "@/contexts/AppContext";
import { errorStatusCodes } from "@/constants/errorStatusCodes";
import { site } from "@/constants/site";
import theme from "@/src/theme";

const AlertData = () => {
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get(site.API_BASE_URL + "");
      } catch (error) {
        setError(error.message);
      }
    };

    fetchData();
  }, []);
  return (
    <>
      <Alert status={error ? "warning" : "info"} justifyContent={"center"}>
        <AlertIcon />
        <Text as={"p"}>
          {error
            ? "Üzgünüm, veritabanından veri çekilemiyor. Fakat Sayfalar arasında gezinmeye devam edebilirsiniz."
            : "Harika! Veriler başarıyla alındı."}
        </Text>
      </Alert>
    </>
  );
};

function MyApp() {
  const router = useRouter();

  const placeholderRoutes = [
    "/privacy-policy",
    "/login",
    "/register",
    "/docs",
    "/api-docs",
    "/401",
    "/403",
    "/404",
    "/409",
    "/500",
    "/501",
    "/502",
    "/503",
  ];
  const anonLayoutRoutes = ["/./"];
  const adminLayoutRoutes = /^\/admin(?:\/|$)/;
  const appLayoutRoutes = /^\/app(?:\/|$)/;
  const meLayoutRoutes = /^\/me(?:\/|$)/;
  const forumLayoutRoutes = /^\/forum(?:\/|$)/;

  const routeLayoutMap = [
    { regex: adminLayoutRoutes, layout: AdminLayout },
    { regex: appLayoutRoutes, layout: AppLayout },
    { regex: meLayoutRoutes, layout: MeLayout },
    { regex: forumLayoutRoutes, layout: ForumLayout },
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
      {errorStatusCodes.includes(200) ? (
        <>
          <PlaceholderLayout statusCode={200} />
        </>
      ) : (
        <AppContextProvider>
          <AuthContextProvider>
            <ChakraProvider theme={theme} resetCSS>
              {/*

*/}

              <AlertData />
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

export default MyApp;
