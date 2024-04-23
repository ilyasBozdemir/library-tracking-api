import { useEffect, useState } from "react";
import {
  Flex,
  Tabs,
  TabList,
  TabPanels,
  Tab,
  TabPanel,
  useColorModeValue,
  SlideFade,
  ScaleFade,
} from "@chakra-ui/react";
import LoginPage from "./LoginPage";
import RegisterPage from "./RegisterPage";
import { useRouter } from "next/router";

const LoginRegisterPage = () => {
  const [activeTab, setActiveTab] = useState(null);
  const [isMounted, setIsMounted] = useState(false);
  const router = useRouter();

  const handleTabChange = (index) => {
    const paths = ["/register", "/login"];
    setActiveTab(index);
    router.push(paths[index]);
  };

  useEffect(() => {
    const paths = ["/register", "/login"];
    const index = paths.findIndex((path) => path === router.pathname);
    if (index !== -1) {
      setActiveTab(index);
    }
    setIsMounted(true);
  }, [router.pathname]);

  const bgColors = useColorModeValue(
    ["teal.50", "blue.50"],
    ["teal.900", "blue.900"]
  );

  const bg = bgColors[activeTab];
  return (
    <>
      <Flex direction="column" justify="center" align="center" >
        <Tabs
          align="center"
          position="relative"
          onChange={handleTabChange}
          defaultIndex={activeTab}
          index={activeTab}
          bg={bg}
          colorScheme={"teal"}
        >
          <TabList>
            <Tab
              _selected={{ color: "white", bg: "teal.400" }}
              onClick={() => handleTabChange(0)}
            >
              Kayıt Ol
            </Tab>
            <Tab
              _selected={{ color: "white", bg: "blue.400" }}
              onClick={() => handleTabChange(1)}
            >
              Giriş Yap
            </Tab>
          </TabList>
          {isMounted && (
            <TabPanels>
              <ScaleFade initialScale={0.5} in={true}>
                <TabPanel>
                  <RegisterPage />
                </TabPanel>
              </ScaleFade>
              <ScaleFade initialScale={0.5} in={true}>
                <TabPanel>
                  <LoginPage />
                </TabPanel>
              </ScaleFade>
            </TabPanels>
          )}
        </Tabs>
      </Flex>
    </>
  );
};

export default LoginRegisterPage;
