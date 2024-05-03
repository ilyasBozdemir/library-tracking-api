import { useEffect, useState } from "react";
import {
  Button,
  Container,
  Tab,
  TabList,
  TabPanel,
  TabPanels,
  Tabs,
  FormControl,
  FormLabel,
  Input,
  Stack,
  Text,
  useToast,
  CheckboxGroup,
  HStack,
  Checkbox,
  VStack,
  Box,
  Heading,
  Switch,
  useColorMode,
} from "@chakra-ui/react";

const LibraryProfileSettingsPage = () => {
  const toast = useToast();
  const [formData, setFormData] = useState({
    name: "",
    address: "",
    phoneNumber: "",
    description: "",
    maxCheckoutLimit: 0,
    minCheckoutDurationInDays: 0,
    maxCheckoutDurationInDays: 0,
    criticalLevelThreshold: 0,
    notifyOnBookOrBlogComment: false,
    topMembersReportLimit: 0,
    topBooksReportLimit: 0,
  });

  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    setFormData((prevData) => ({
      ...prevData,
      [name]: type === "checkbox" ? checked : value,
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(formData);
    toast({
      title: "Ayarlar güncellendi",
      status: "success",
      duration: 2000,
      isClosable: true,
    });
  };

  return (
    <Container maxW="5xl">
      <Tabs overflow={"auto"}>
        <TabList>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
          >
            Genel Ayarlar
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
          >
            Kütüphane Bilgileri
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
          >
            Eser Ayarları
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
          >
            Üye Ayarları
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
          >
            Çalışan Ayarları
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
          >
            Gizlilik Ayarları
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
          >
            Sosyal Medya Ayarları
          </Tab>
        </TabList>
        <TabPanels>
          <TabPanel>
            <GeneralSettingsPage />
          </TabPanel>
          <TabPanel>
            <form onSubmit={handleSubmit}>
              <Stack spacing={4}>
                <FormControl id="name">
                  <FormLabel>Kütüphane Adı</FormLabel>
                  <Input
                    type="text"
                    name="name"
                    value={formData.name}
                    onChange={handleChange}
                  />
                </FormControl>
                <FormControl id="address">
                  <FormLabel>Adres</FormLabel>
                  <Input
                    type="text"
                    name="address"
                    value={formData.address}
                    onChange={handleChange}
                  />
                </FormControl>
                <FormControl id="phoneNumber">
                  <FormLabel>Telefon Numarası</FormLabel>
                  <Input
                    type="text"
                    name="phoneNumber"
                    value={formData.phoneNumber}
                    onChange={handleChange}
                  />
                </FormControl>
                <FormControl id="description">
                  <FormLabel>Açıklama</FormLabel>
                  <Input
                    type="text"
                    name="description"
                    value={formData.description}
                    onChange={handleChange}
                  />
                </FormControl>
                <Button type="submit" colorScheme="teal">
                  Kaydet
                </Button>
              </Stack>
            </form>
          </TabPanel>
          <TabPanel>
            <form onSubmit={handleSubmit}>
              <Stack spacing={4}>
                <FormControl id="maxCheckoutLimit">
                  <FormLabel>Azami Ödünç Alma Adedi</FormLabel>
                  <Input
                    type="number"
                    name="maxCheckoutLimit"
                    value={formData.maxCheckoutLimit}
                    onChange={handleChange}
                  />
                </FormControl>
                <FormControl id="minCheckoutDurationInDays">
                  <FormLabel>Asgari Teslim Süresi (Gün)</FormLabel>
                  <Input
                    type="number"
                    name="minCheckoutDurationInDays"
                    value={formData.minCheckoutDurationInDays}
                    onChange={handleChange}
                  />
                </FormControl>
                <FormControl id="maxCheckoutDurationInDays">
                  <FormLabel>Azami Teslim Süresi (Gün)</FormLabel>
                  <Input
                    type="number"
                    name="maxCheckoutDurationInDays"
                    value={formData.maxCheckoutDurationInDays}
                    onChange={handleChange}
                  />
                </FormControl>
                <FormControl id="criticalLevelThreshold">
                  <FormLabel>Eser Kritik Seviyesi</FormLabel>
                  <Input
                    type="number"
                    name="criticalLevelThreshold"
                    value={formData.criticalLevelThreshold}
                    onChange={handleChange}
                  />
                </FormControl>
                <FormControl id="notifyOnBookOrBlogComment">
                  <FormLabel>Eser veya Blog Yorumu Bildirimi</FormLabel>
                  <input
                    type="checkbox"
                    name="notifyOnBookOrBlogComment"
                    checked={formData.notifyOnBookOrBlogComment}
                    onChange={handleChange}
                  />
                </FormControl>
                <FormControl id="topMembersReportLimit">
                  <FormLabel>En Çok Okuyan Üyeler Raporu Limiti</FormLabel>
                  <Input
                    type="number"
                    name="topMembersReportLimit"
                    value={formData.topMembersReportLimit}
                    onChange={handleChange}
                  />
                </FormControl>
                <FormControl id="topBooksReportLimit">
                  <FormLabel>En Çok Okunan Kitaplar Raporu Limiti</FormLabel>
                  <Input
                    type="number"
                    name="topBooksReportLimit"
                    value={formData.topBooksReportLimit}
                    onChange={handleChange}
                  />
                </FormControl>
                <Button type="submit" colorScheme="teal">
                  Kaydet
                </Button>
              </Stack>
            </form>
          </TabPanel>
          <TabPanel>
            <Container maxW="xl">
              <Stack spacing={4}>
                <FormControl id="notification">
                  <FormLabel>Bildirim Ayarları</FormLabel>
                  <CheckboxGroup colorScheme="teal" defaultValue={["email"]}>
                    <HStack spacing={4}>
                      <Checkbox value="email">E-posta Bildirimleri</Checkbox>
                      <Checkbox value="sms">SMS Bildirimleri</Checkbox>
                    </HStack>
                  </CheckboxGroup>
                </FormControl>
                <Button colorScheme="teal">Değişiklikleri Kaydet</Button>
              </Stack>
            </Container>
          </TabPanel>
          <TabPanel>
            <EmployeeSettingsPage />
          </TabPanel>
          <TabPanel>
            <PrivacySettingsPage />
          </TabPanel>
          <TabPanel>
            <SocialMediaSettingsPage />
          </TabPanel>
        </TabPanels>
      </Tabs>
    </Container>
  );
};

const GeneralSettingsPage = () => {
  const { colorMode, toggleColorMode } = useColorMode();
  const toast = useToast();
  const [formData, setFormData] = useState({
    enableDarkMode: false,
    enableNotifications: true,
    enableEmailNotifications: false,
    enableAutoApproval: false,
  });

  useEffect(() => {
    const channelBroadcast = () => {};
    const channel = new BroadcastChannel("themeChannel");
    let newColorMode = "";

    if (formData.enableDarkMode) {
      newColorMode = "dark";
    } else {
      newColorMode = "light";
    }

    channel.postMessage({ colorMode: newColorMode });

    channelBroadcast();
  }, [formData.enableDarkMode]);

  const handleChange = (e) => {
    const { name, checked } = e.target;

    setFormData((prevData) => ({
      ...prevData,
      [name]: checked,
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(formData);
    toast({
      title: "Ayarlar güncellendi",
      status: "success",
      duration: 2000,
      isClosable: true,
    });
  };

  return (
    <Container maxW="xl">
      <form onSubmit={handleSubmit}>
        <Stack spacing={4}>
          <Box>
            <Text fontWeight="bold">Karanlık Modu Etkinleştir</Text>
            <Switch
              name="enableDarkMode"
              isChecked={formData.enableDarkMode}
              onChange={handleChange}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">Bildirimleri Etkinleştir</Text>
            <Switch
              name="enableNotifications"
              isChecked={formData.enableNotifications}
              onChange={handleChange}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">E-posta Bildirimlerini Etkinleştir</Text>
            <Switch
              name="enableEmailNotifications"
              isChecked={formData.enableEmailNotifications}
              onChange={handleChange}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">Otomatik Onayı Etkinleştir</Text>
            <Switch
              name="enableAutoApproval"
              isChecked={formData.enableAutoApproval}
              onChange={handleChange}
            />
          </Box>
          <Button type="submit" colorScheme="teal">
            Değişiklikleri Kaydet
          </Button>
        </Stack>
      </form>
    </Container>
  );
};

const EmployeeSettingsPage = () => {
  const toast = useToast();
  const [formData, setFormData] = useState({
    enableNotifications: true,
    enableEmailNotifications: false,
    enableAutoApproval: false,
    enablePerformanceMetrics: true,
    enableEmployeeDirectory: true,
  });

  const handleChange = (e) => {
    const { name, checked } = e.target;
    setFormData((prevData) => ({
      ...prevData,
      [name]: checked,
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(formData);
    toast({
      title: "Ayarlar güncellendi",
      status: "success",
      duration: 2000,
      isClosable: true,
    });
  };

  return (
    <Container maxW="xl">
      <Heading as="h1" size="xl" mb={8}>
        Çalışan Ayarları
      </Heading>
      <form onSubmit={handleSubmit}>
        <Stack spacing={4}>
          <Box>
            <Text fontWeight="bold">Bildirimleri Etkinleştir</Text>
            <Switch
              name="enableNotifications"
              isChecked={formData.enableNotifications}
              onChange={handleChange}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">E-posta Bildirimlerini Etkinleştir</Text>
            <Switch
              name="enableEmailNotifications"
              isChecked={formData.enableEmailNotifications}
              onChange={handleChange}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">Otomatik Onayı Etkinleştir</Text>
            <Switch
              name="enableAutoApproval"
              isChecked={formData.enableAutoApproval}
              onChange={handleChange}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">Performans Metriklerini Görüntüle</Text>
            <Switch
              name="enablePerformanceMetrics"
              isChecked={formData.enablePerformanceMetrics}
              onChange={handleChange}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">Çalışan Rehberini Görüntüle</Text>
            <Switch
              name="enableEmployeeDirectory"
              isChecked={formData.enableEmployeeDirectory}
              onChange={handleChange}
            />
          </Box>
          <Button type="submit" colorScheme="teal">
            Değişiklikleri Kaydet
          </Button>
        </Stack>
      </form>
    </Container>
  );
};

const PrivacySettingsPage = () => {
  const toast = useToast();
  const [formData, setFormData] = useState({
    enableAnalytics: true,
    enablePersonalizedAds: false,
    enableLocationSharing: false,
  });

  const handleChange = (e) => {
    const { name, checked } = e.target;
    setFormData((prevData) => ({
      ...prevData,
      [name]: checked,
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(formData);
    toast({
      title: "Ayarlar güncellendi",
      status: "success",
      duration: 2000,
      isClosable: true,
    });
  };

  return (
    <Container maxW="xl">
      <Heading as="h1" size="xl" mb={8}>
        Gizlilik Ayarları
      </Heading>
      <form onSubmit={handleSubmit}>
        <Stack spacing={4}>
          <Box>
            <Text fontWeight="bold">Analitik Verileri Etkinleştir</Text>
            <Switch
              name="enableAnalytics"
              isChecked={formData.enableAnalytics}
              onChange={handleChange}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">
              Kişiselleştirilmiş Reklamları Etkinleştir
            </Text>
            <Switch
              name="enablePersonalizedAds"
              isChecked={formData.enablePersonalizedAds}
              onChange={handleChange}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">Konum Paylaşımını Etkinleştir</Text>
            <Switch
              name="enableLocationSharing"
              isChecked={formData.enableLocationSharing}
              onChange={handleChange}
            />
          </Box>
          <Button type="submit" colorScheme="teal">
            Değişiklikleri Kaydet
          </Button>
        </Stack>
      </form>
    </Container>
  );
};
const SocialMediaSettingsPage = () => {
  const toast = useToast();

  const [socialMediaLinks, setSocialMediaLinks] = useState({
    facebook: "",
    twitter: "",
    instagram: "",
    tiktok: "",
  });

  const [pixelCodes, setPixelCodes] = useState({
    facebook: "",
    linkedin: "",
    googleTagManager: "",
    googleAnalytics: "",
  });

  const [emailAccounts, setEmailAccounts] = useState([
    {
      server: "",
      port: "",
      email: "",
      password: "",
      displayName: "",
    },
  ]);

  const handleSocialMediaChange = (e, platform) => {
    const { value } = e.target;
    setSocialMediaLinks((prevLinks) => ({
      ...prevLinks,
      [platform]: value,
    }));
  };

  const handlePixelCodeChange = (e, platform) => {
    const { value } = e.target;
    setPixelCodes((prevCodes) => ({
      ...prevCodes,
      [platform]: value,
    }));
  };

  const handleEmailAccountChange = (e, index) => {
    const { name, value } = e.target;
    setEmailAccounts((prevAccounts) => {
      const updatedAccounts = [...prevAccounts];
      updatedAccounts[index][name] = value;
      return updatedAccounts;
    });
  };

  const addEmailAccount = () => {
    setEmailAccounts((prevAccounts) => [
      ...prevAccounts,
      {
        server: "",
        port: "",
        email: "",
        password: "",
        displayName: "",
      },
    ]);
  };

  const removeEmailAccount = (index) => {
    setEmailAccounts((prevAccounts) => {
      const updatedAccounts = [...prevAccounts];
      updatedAccounts.splice(index, 1);
      return updatedAccounts;
    });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log("Social Media Links:", socialMediaLinks);
    console.log("Pixel Codes:", pixelCodes);
    console.log("Email Accounts:", emailAccounts);
    toast({
      title: "Ayarlar güncellendi",
      status: "success",
      duration: 2000,
      isClosable: true,
    });
  };

  return (
    <Container maxW="5xl">
      <Tabs align={"center"}>
        <TabList>
          <Tab>Sosyal Medya</Tab>
          <Tab>Takip Kodları</Tab>
          <Tab>E-posta Hesapları</Tab>
        </TabList>
        <TabPanels>
          <TabPanel>
            <form onSubmit={handleSubmit}>
              <Stack spacing={4}>
                <FormControl id="facebook">
                  <FormLabel>Facebook Linki</FormLabel>
                  <Input
                    type="text"
                    value={socialMediaLinks.facebook}
                    onChange={(e) => handleSocialMediaChange(e, "facebook")}
                  />
                </FormControl>
                <FormControl id="twitter">
                  <FormLabel>Twitter Linki</FormLabel>
                  <Input
                    type="text"
                    value={socialMediaLinks.twitter}
                    onChange={(e) => handleSocialMediaChange(e, "twitter")}
                  />
                </FormControl>
                <FormControl id="instagram">
                  <FormLabel>Instagram Linki</FormLabel>
                  <Input
                    type="text"
                    value={socialMediaLinks.instagram}
                    onChange={(e) => handleSocialMediaChange(e, "instagram")}
                  />
                </FormControl>
                <FormControl id="tiktok">
                  <FormLabel>TikTok Linki</FormLabel>
                  <Input
                    type="text"
                    value={socialMediaLinks.tiktok}
                    onChange={(e) => handleSocialMediaChange(e, "tiktok")}
                  />
                </FormControl>
                <Button type="submit" colorScheme="teal">
                  Kaydet
                </Button>
              </Stack>
            </form>
          </TabPanel>
          <TabPanel>
            <form onSubmit={handleSubmit}>
              <Stack spacing={4}>
                <FormControl id="facebookPixelCode">
                  <FormLabel>Facebook Pixel Kodu</FormLabel>
                  <Input
                    type="text"
                    value={pixelCodes.facebook}
                    onChange={(e) => handlePixelCodeChange(e, "facebook")}
                  />
                </FormControl>
                <FormControl id="linkedinPixelCode">
                  <FormLabel>LinkedIn Pixel Kodu</FormLabel>
                  <Input
                    type="text"
                    value={pixelCodes.linkedin}
                    onChange={(e) => handlePixelCodeChange(e, "linkedin")}
                  />
                </FormControl>
                <FormControl id="googleTagManager">
                  <FormLabel>Google Tag Manager Kodu</FormLabel>
                  <Input
                    type="text"
                    value={pixelCodes.googleTagManager}
                    onChange={(e) =>
                      handlePixelCodeChange(e, "googleTagManager")
                    }
                  />
                </FormControl>
                <FormControl id="googleAnalytics">
                  <FormLabel>Google Analytics Kodu</FormLabel>
                  <Input
                    type="text"
                    value={pixelCodes.googleAnalytics}
                    onChange={(e) =>
                      handlePixelCodeChange(e, "googleAnalytics")
                    }
                  />
                </FormControl>
                <Button type="submit" colorScheme="teal">
                  Kaydet
                </Button>
              </Stack>
            </form>
          </TabPanel>
          <TabPanel>
            <form onSubmit={handleSubmit}>
              {emailAccounts.map((account, index) => (
                <Stack spacing={4} key={index}>
                  <FormControl id={`server${index}`}>
                    <FormLabel>Sunucu</FormLabel>
                    <Input
                      type="text"
                      name="server"
                      value={account.server}
                      onChange={(e) => handleEmailAccountChange(e, index)}
                    />
                  </FormControl>
                  <FormControl id={`port${index}`}>
                    <FormLabel>Port</FormLabel>
                    <Input
                      type="text"
                      name="port"
                      value={account.port}
                      onChange={(e) => handleEmailAccountChange(e, index)}
                    />
                  </FormControl>
                  <FormControl id={`email${index}`}>
                    <FormLabel>E-posta</FormLabel>
                    <Input
                      type="text"
                      name="email"
                      value={account.email}
                      onChange={(e) => handleEmailAccountChange(e, index)}
                    />
                  </FormControl>
                  <FormControl id={`password${index}`}>
                    <FormLabel>Şifre</FormLabel>
                    <Input
                      type="password"
                      name="password"
                      value={account.password}
                      onChange={(e) => handleEmailAccountChange(e, index)}
                    />
                  </FormControl>
                  <FormControl id={`displayName${index}`}>
                    <FormLabel>Görüntülenen Ad</FormLabel>
                    <Input
                      type="text"
                      name="displayName"
                      value={account.displayName}
                      onChange={(e) => handleEmailAccountChange(e, index)}
                    />
                  </FormControl>
                  <Button
                    type="button"
                    onClick={() => removeEmailAccount(index)}
                    colorScheme="red"
                  >
                    Hesabı Kaldır
                  </Button>
                </Stack>
              ))}
              <VStack>
                <Button type="button" mt={3} onClick={addEmailAccount}>
                  Yeni Hesap Ekle
                </Button>
                <Button type="submit" colorScheme="teal">
                  Kaydet
                </Button>
              </VStack>
            </form>
          </TabPanel>
        </TabPanels>
      </Tabs>
    </Container>
  );
};

export default LibraryProfileSettingsPage;
