import { useState } from 'react';
import {Flex, Tabs, TabList, TabPanels, Tab, TabPanel } from '@chakra-ui/react';
import LoginPage from './LoginPage';
import RegisterPage from './RegisterPage';
import { useRouter } from 'next/router';

const LoginRegisterPage = () => {
  const [activeTab, setActiveTab] = useState(0);
  const router = useRouter();
  const handleTabChange = (index) => {
    switch (index) {
      case 0:
        router.push('/login');
        break;
      case 1:
        router.push('/register');
        break;
      default:
        break;
    }
  };
  return (
<Flex direction="column" justify="center" align="center" h="100vh">
  <Tabs isFitted variant="enclosed" onChange={handleTabChange}>
    <TabList>
      <Tab onClick={() => setActiveTab(0)}>Giriş Yap</Tab>
      <Tab onClick={() => setActiveTab(1)}>Kayıt Ol</Tab>
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
