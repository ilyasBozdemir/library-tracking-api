import { useEffect, useState } from "react";
import {
  Flex,
  Tabs,
  TabList,
  TabPanels,
  Tab,
  TabPanel,
} from "@chakra-ui/react";
import LoginPage from "./LoginPage";
import RegisterPage from "./RegisterPage";
import { useRouter } from "next/router";

const LoginRegisterPage = () => {
  const [activeTab, setActiveTab] = useState(0);
  const router = useRouter();

  const handleTabChange = (index) => {
    setActiveTab(index);
    switch (index) {
      case 0:
        router.push("/login");
        break;
      case 1:
        router.push("/register");
        break;
      default:
        break;
    }
  };

  useEffect(() => {
    if (router.pathname === "/login") {
      setActiveTab(0);
    } else if (router.pathname === "/register") {
      setActiveTab(1);
    }
  }, [router.pathname]);

  return (
    <Flex direction="column" justify="center" align="center" h="100vh">
      <Tabs
        isFitted
        variant="soft-rounded"
        onChange={handleTabChange}
        defaultIndex={activeTab}
        index={activeTab}
      >
        <TabList>
          <Tab onClick={() => handleTabChange(0)}>Giriş Yap</Tab>
          <Tab onClick={() => handleTabChange(1)}>Kayıt Ol</Tab>
        </TabList>
        <TabPanels>
          <TabPanel>
            <LoginPage />
          </TabPanel>
          <TabPanel>
            <RegisterPage />
          </TabPanel>
        </TabPanels>
      </Tabs>
    </Flex>
  );
};

export default LoginRegisterPage;
