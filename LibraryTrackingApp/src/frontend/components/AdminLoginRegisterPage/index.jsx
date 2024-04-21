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

//admin register yok create user ve sonra rol atamam kısmı olucak.
//şimdilik kalsın

const LoginRegisterPage = () => {
  const [activeTab, setActiveTab] = useState(null);
  const router = useRouter();

  const handleTabChange = (index) => {
    setActiveTab(index);
    switch (index) {
      case 0:
        router.push("/admin/register");
        break;
      case 1:
        router.push("/admin/login");
        break;
      default:
        break;
    }
  };

  useEffect(() => {
    if (router.pathname === "/admin/login") {
      setActiveTab(1);
    } else if (router.pathname === "/admin/register") {
      setActiveTab(0);
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
        colorScheme={"teal"}
      >
        <TabList>
          <Tab onClick={() => handleTabChange(0)}>Kayıt Ol</Tab>
          <Tab onClick={() => handleTabChange(1)}>Giriş Yap</Tab>
        </TabList>
        <TabPanels>
          <TabPanel>
            <RegisterPage />
          </TabPanel>
          <TabPanel>
            <LoginPage />
          </TabPanel>
        </TabPanels>
      </Tabs>
    </Flex>
  );
};

export default LoginRegisterPage;
