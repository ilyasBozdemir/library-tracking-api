import { useEffect, useRef, useState } from "react";
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
  InputGroup,
  InputLeftAddon,
  Icon,
  InputRightAddon,
  Flex,
  Select,
  Table,
  TableCaption,
  Thead,
  Tr,
  Th,
  Tbody,
  Td,
  IconButton,
  SimpleGrid,
  TableContainer,
} from "@chakra-ui/react";

import {
  AlertDialog,
  AlertDialogBody,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogContent,
  AlertDialogOverlay,
} from "@chakra-ui/react";

import { useApp } from "@/contexts/AppContext";

import { CgWebsite } from "react-icons/cg";
import { FiFacebook, FiInstagram } from "react-icons/fi";
import { FaXTwitter } from "react-icons/fa6";
import { SiTiktok } from "react-icons/si";
import { SlSocialLinkedin } from "react-icons/sl";
import { MdOutlineDelete } from "react-icons/md";

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

  const [activeTab, setActiveTab] = useState(0);
  const handleTabChange = (index) => {
    setActiveTab(index);
  };

  return (
    <Container maxW="6xl">
      <Tabs
        overflow="auto"
        onChange={handleTabChange}
        index={activeTab}
        defaultIndex={activeTab}
      >
        <TabList>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
            onClick={() => setActiveTab(0)}
          >
            Genel Ayarlar
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
            onClick={() => setActiveTab(1)}
          >
            Kütüphane Bilgileri
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
            onClick={() => setActiveTab(2)}
          >
            Eser Ayarları
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
            onClick={() => setActiveTab(0)}
          >
            Üye Ayarları
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
            onClick={() => setActiveTab(4)}
          >
            Çalışan Ayarları
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
            onClick={() => setActiveTab(5)}
          >
            Gizlilik Ayarları
          </Tab>
          <Tab
            _selected={{
              color: "white",
              bg: "teal.500",
            }}
            onClick={() => setActiveTab(6)}
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
              colorScheme={'teal'}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">Bildirimleri Etkinleştir</Text>
            <Switch
              name="enableNotifications"
              isChecked={formData.enableNotifications}
              onChange={handleChange}
              colorScheme={'teal'}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">E-posta Bildirimlerini Etkinleştir</Text>
            <Switch
              name="enableEmailNotifications"
              isChecked={formData.enableEmailNotifications}
              onChange={handleChange}
              colorScheme={'teal'}
            />
          </Box>
          <Box>
            <Text fontWeight="bold">Otomatik Onayı Etkinleştir</Text>
            <Switch
              name="enableAutoApproval"
              isChecked={formData.enableAutoApproval}
              onChange={handleChange}
              colorScheme={'teal'}
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
  const { analytics, setAnalytics } = useApp();
  const [activeSubTab, setActiveSubTab] = useState(0);

  const handleTabChange = (index) => {
    setActiveSubTab(index);
  };

  const [purposes, setPurposes] = useState([
    { name: "Bildirim", value: "notification" },
    { name: "Ödünç/İade", value: "borrow_return" },
    { name: "Hatırlatma", value: "reminding" },
    { name: "Destek", value: "support" },
    { name: "Abonelik", value: "subscription" },
    { name: "Reklam", value: "advertisement" },
    { name: "Etkinlik", value: "event" },
    { name: "Fatura ve Ödeme", value: "billing_payment" },
    { name: "Kimlik Doğrulama ve Onay", value: "authentication_confirmation" },
  ]);

  const [emailAccounts, setEmailAccounts] = useState([
    {
      id: "",
      purpose: "",
      server: "",
      port: "",
      email: "",
      password: "",
      displayName: "",
    },
  ]);

  const handleEmailAccountChange = (e, index) => {
    const { name, value } = e.target;
    console.log();
    setEmailAccounts((prevAccounts) => {
      const updatedAccounts = [...prevAccounts];
      updatedAccounts[index][name] = value;
      return updatedAccounts;
    });
  };
  const addEmailAccount = () => {
    const isEmpty = emailAccounts.some(
      (account) => account.email.trim() === ""
    );

    if (!isEmpty) {
      setEmailAccounts((prevAccounts) => [
        ...prevAccounts,
        {
          id: "",
          purpose: "",
          server: "",
          port: "",
          email: "",
          password: "",
          displayName: "",
        },
      ]);
    }
  };

  const handlePixelCodeChange = (e, name) => {
    const { value } = e.target;
    setAnalytics((prevAnalytics) => ({
      ...prevAnalytics,
      [name]: { ...prevAnalytics[name], code: value },
    }));
  };
  
  const handleCheckboxChange = (name) => {
    setAnalytics((prevAnalytics) => ({
      ...prevAnalytics,
      [name]: { ...prevAnalytics[name], isActive: !prevAnalytics[name].isActive },
    }));
  };
  const handleSubmit = (e) => {
    e.preventDefault();
    toast({
      title: "Ayarlar güncellendi",
      status: "success",
      duration: 2000,
      isClosable: true,
    });
  };

  const [isOpen, setIsOpen] = useState(false);
  const [accountToRemove, setAccountToRemove] = useState(null);
  const cancelRef = useRef();

  const removeEmailAccount = (index) => {
    setIsOpen(true);
    setAccountToRemove(index);
  };

  const handleClose = () => setIsOpen(false);

  const handleConfirmRemove = () => {
    setIsOpen(false);
    setEmailAccounts((prevAccounts) => {
      const updatedAccounts = [...prevAccounts];
      updatedAccounts.splice(accountToRemove, 1);
      return updatedAccounts;
    });
  };

  return (
    <Container maxW="7xl">
      <Tabs
        align={"center"}
        defaultIndex={activeSubTab}
        onChange={handleTabChange}
        index={activeSubTab}
      >
        <TabList>
          <Tab
            _selected={{ color: "white", bg: "teal.400" }}
            onClick={() => setActiveSubTab(0)}
          >
            Sosyal Medya
          </Tab>
          <Tab
            _selected={{ color: "white", bg: "teal.400" }}
            onClick={() => setActiveSubTab(1)}
          >
            Takip Kodları
          </Tab>
          <Tab
            _selected={{ color: "white", bg: "teal.400" }}
            onClick={() => setActiveSubTab(2)}
          >
            E-posta Hesapları
          </Tab>
        </TabList>
        <TabPanels>
          <TabPanel>
            <SocialMediaLinksTab />
          </TabPanel>
          <TabPanel>
            <form onSubmit={handleSubmit}>
              <Stack spacing={4}>
                {Object.keys(analytics).map((key, index) => (
                  <FormControl key={index} id={key}>
                    <FormLabel>{key} Kodu</FormLabel>
                    <Input
                      type="text"
                      value={analytics[key].code}
                      onChange={(e) => handlePixelCodeChange(e, key)}
                    />
                    <Checkbox
                      isChecked={analytics[key].isActive}
                      onChange={() => handleCheckboxChange(key)}
                    >
                      Aktif/Pasif
                    </Checkbox>
                  </FormControl>
                ))}
                <Button type="submit" variant={"outline"} colorScheme="teal">
                  Kaydet
                </Button>
              </Stack>
            </form>
          </TabPanel>
          <TabPanel>
            <>
              <SimpleGrid columns={{ base: 1 }} spacing={6}>
                <TableContainer overflowX={{ base: "scroll", md: "unset" }}>
                  <Table variant="simple">
                    <TableCaption placement="top">
                      Mail Hesapları Yapılandırma Alanı
                    </TableCaption>
                    <Thead>
                      <Tr>
                        <Th>Alan</Th>
                        <Th>Sunucu</Th>
                        <Th>Port</Th>
                        <Th>E-posta</Th>
                        <Th>Şifre</Th>
                        <Th>Varsayılan</Th>
                        <Th></Th>
                      </Tr>
                    </Thead>
                    <Tbody>
                      {emailAccounts.map((account, index) => (
                        <Tr key={index}>
                          <Td>
                            <FormControl id={`purpose${index}`} isRequired>
                              <Select
                                name="purpose"
                                value={account.purpose}
                                onChange={(e) =>
                                  handleEmailAccountChange(e, index)
                                }
                              >
                                <option value="">Amaç Seçin</option>
                                {purposes.map((purpose, index) => (
                                  <option key={index} value={purpose.value}>
                                    {purpose.name}
                                  </option>
                                ))}
                              </Select>
                            </FormControl>
                          </Td>
                          <Td>
                            <FormControl id={`server${index}`}>
                              <Input
                                type="text"
                                name="server"
                                value={account.server}
                                onChange={(e) =>
                                  handleEmailAccountChange(e, index)
                                }
                              />
                            </FormControl>
                          </Td>
                          <Td>
                            <FormControl id={`port${index}`}>
                              <Input
                                type="text"
                                name="port"
                                value={account.port}
                                onChange={(e) =>
                                  handleEmailAccountChange(e, index)
                                }
                              />
                            </FormControl>
                          </Td>
                          <Td>
                            <FormControl id={`email${index}`}>
                              <Input
                                type="text"
                                name="email"
                                value={account.email}
                                onChange={(e) =>
                                  handleEmailAccountChange(e, index)
                                }
                              />
                            </FormControl>
                          </Td>
                          <Td>
                            <FormControl id={`password${index}`}>
                              <Input
                                type="password"
                                name="password"
                                value={account.password}
                                onChange={(e) =>
                                  handleEmailAccountChange(e, index)
                                }
                              />
                            </FormControl>
                          </Td>
                          <Td>
                            <IconButton
                              onClick={() => removeEmailAccount(index)}
                              colorScheme="red"
                              icon={<MdOutlineDelete />}
                            />
                          </Td>
                        </Tr>
                      ))}
                    </Tbody>
                  </Table>
                </TableContainer>
                <Box>
                  <Flex gap={3} justify="center" alignItems="center">
                    <Button
                      type="button"
                      variant="outline"
                      colorScheme="teal"
                      onClick={addEmailAccount}
                    >
                      Yeni Hesap Ekle
                    </Button>
                    <Button
                      type="submit"
                      variant="outline"
                      colorScheme="blue"
                      onClick={handleSubmit}
                    >
                      Kaydet
                    </Button>
                  </Flex>
                  <Text as="small" mt={4}>
                    Bu alan, mail hesaplarınızı yapılandırmak için kullanılır.
                    Şifreler AES şifreleme ile saklanmaktadır.
                  </Text>
                </Box>
              </SimpleGrid>
              <>
                <AlertDialog
                  isOpen={isOpen}
                  leastDestructiveRef={cancelRef}
                  onClose={handleClose}
                >
                  <AlertDialogOverlay>
                    <AlertDialogContent>
                      <AlertDialogHeader fontSize="lg" fontWeight="bold">
                        Hesabı Sil
                      </AlertDialogHeader>

                      <AlertDialogBody>
                        Hesabı silmek istediğinizden emin misiniz? Bu işlem geri
                        alınamaz.
                      </AlertDialogBody>

                      <AlertDialogFooter>
                        <Button ref={cancelRef} onClick={handleClose}>
                          İptal
                        </Button>
                        <Button
                          colorScheme="red"
                          onClick={handleConfirmRemove}
                          ml={3}
                        >
                          Sil
                        </Button>
                      </AlertDialogFooter>
                    </AlertDialogContent>
                  </AlertDialogOverlay>
                </AlertDialog>
              </>
            </>
          </TabPanel>
        </TabPanels>
      </Tabs>
    </Container>
  );
};

const SocialMediaLinksTab = () => {
  // backend'e bağlanacaktır daha...
  const toast = useToast();

  const [socialMediaLinks, setSocialMediaLinks] = useState({
    website: "",
    facebook: "",
    x: "",
    instagram: "",
    tiktok: "",
    linkedin: "",
  });

  const links = [
    {
      id: "website",
      label: "Website Linki",
      value: socialMediaLinks.website,
      type: "text",
      icon: CgWebsite,
      onChange: (e) => handleSocialMediaChange(e, "website"),
      placeHolder: "",
      variant: socialMediaLinks.website ? "filled" : "outline",
      color: "gray.500",
    },
    {
      id: "facebook",
      label: "Facebook Linki",
      value: socialMediaLinks.facebook,
      type: "text",
      icon: FiFacebook,
      onChange: (e) => handleSocialMediaChange(e, "facebook"),
      placeHolder: "",
      variant: socialMediaLinks.facebook ? "filled" : "outline",
      color: "#3b5998",
    },
    {
      id: "instagram",
      label: "İnstagram Linki",
      value: socialMediaLinks.instagram,
      type: "text",
      icon: FiInstagram,
      onChange: (e) => handleSocialMediaChange(e, "instagram"),
      placeHolder: "",
      variant: socialMediaLinks.instagram ? "filled" : "outline",
      color: "#c13584",
    },
    {
      id: "x",
      label: "X Linki",
      value: socialMediaLinks.x,
      type: "text",
      icon: FaXTwitter,
      onChange: (e) => handleSocialMediaChange(e, "x"),
      placeHolder: "",
      variant: socialMediaLinks.x ? "filled" : "outline",
      color: "#1da1f2",
    },
    {
      id: "tiktok",
      label: "Tiktok Linki",
      value: socialMediaLinks.tiktok,
      type: "text",
      icon: SiTiktok,
      onChange: (e) => handleSocialMediaChange(e, "tiktok"),
      placeHolder: "",
      variant: socialMediaLinks.tiktok ? "filled" : "outline",
      color: "#69c9d0",
    },
    {
      id: "linkedin",
      label: "Linkedin Linki",
      value: socialMediaLinks.linkedin,
      type: "text",
      icon: SlSocialLinkedin,
      onChange: (e) => handleSocialMediaChange(e, "linkedin"),
      placeHolder: "",
      variant: socialMediaLinks.linkedin ? "filled" : "outline",
      color: "#0077b5",
    },
  ];

  const handleSubmit = (e) => {
    e.preventDefault();

    toast({
      title: "Sosyal Medya Linkleri Başarıyla Güncellendi.",
      status: "success",
      duration: 2000,
      isClosable: true,
    });
  };
  const handleSocialMediaChange = (e, platform) => {
    const { value } = e.target;
    setSocialMediaLinks((prevLinks) => ({
      ...prevLinks,
      [platform]: value,
    }));
  };

  return (
    <>
      <Flex
        as={"form"}
        onSubmit={handleSubmit}
        gap={4}
        direction={"column"}
        justifyContent={"center"}
      >
        {links.map((link) => (
          <FormControl key={link.id} id={link.id}>
            <FormLabel>{link.label}</FormLabel>
            <InputGroup size="sm">
              <InputLeftAddon>
                <Icon as={link.icon} color={link.color} />
              </InputLeftAddon>
              <Input
                type={link.type}
                value={link.value}
                onChange={link.onChange}
                placeholder={link.placeHolder}
                variant={link.variant}
                focusBorderColor="teal.400"
              />
              {/* 
                  <InputRightAddon>
                  
                  </InputRightAddon>
                  */}
            </InputGroup>
          </FormControl>
        ))}
        <Button type="submit" colorScheme="teal">
          Kaydet
        </Button>
      </Flex>
    </>
  );
};

export default LibraryProfileSettingsPage;
