import { useEffect, useState } from "react";
import {
  Box,
  Heading,
  VStack,
  Text,
  Input,
  Button,
  Divider,
  Tab,
  TabList,
  TabPanel,
  TabPanels,
  Tabs,
  Flex,
} from "@chakra-ui/react";
import { FiMessageSquare } from "react-icons/fi";
import { IoCreateOutline } from "react-icons/io5";

const SupportPage = () => {
  const [title, setTitle] = useState("");
  const [message, setMessage] = useState("");
  const [supportRequests, setSupportRequests] = useState([
    {
      id: 1,
      title: "Kütüphane Açılış Saati Değişikliği",
      message:
        "Kütüphane açılış saati hafta içi saat 10:00'dan 08:00'e alındı. Bu değişiklik hakkında bilgi almak istiyorum.",
      status: "Açık",
    },
    {
      id: 2,
      title: "Kitap İade Süresi Uzatma",
      message: "Kitap iade süresini uzatmak istiyorum. Acaba mümkün mü?",
      status: "Kapalı",
    },
  ]);

  const [memberTitle, setMemberTitle] = useState("");
  const [memberMessage, setMemberMessage] = useState("");
  const [supportMemberRequests, setSupportMemberRequests] = useState([
    {
      id: 1,
      title: "Kütüphane Açılış Saati Değişikliği",
      message:
        "Kütüphane açılış saati hafta içi saat 10:00'dan 08:00'e alındı. Bu değişiklik hakkında bilgi almak istiyorum.",
      status: "Açık",
    },
    {
      id: 2,
      title: "Kitap İade Süresi Uzatma",
      message: "Kitap iade süresini uzatmak istiyorum. Acaba mümkün mü?",
      status: "Kapalı",
    },
  ]);

  const handleSubmit = () => {
    console.log("Destek talebi gönderildi:", { memberTitle, memberMessage });
    if (memberTitle && memberMessage) {
      setSupportMemberRequests([
        ...supportMemberRequests,
        { id: Date.now(), memberTitle, memberMessage, status: "Açık" },
      ]);
      setMemberTitle("");
      setMemberMessage("");
      setShow(false);
    }
  };

  const [show, setShow] = useState(false);

  return (
    <Box p="5">
      <Flex justifyContent={"center"}>
        <Heading mb="4">Destek Talepleri</Heading>
      </Flex>
      <Tabs align="center" colorScheme={"teal"}>
        <TabList>
          <Tab>Üyelerin Destek Talepleri</Tab>
          <Tab>Destek Taleplerim</Tab>
        </TabList>

        <TabPanels>
          <TabPanel>
            <VStack spacing="4" align="start">
              <VStack spacing="4" align="start">
                {supportRequests.map((request) => (
                  <Box
                    key={request.id}
                    w="100%"
                    border="1px solid"
                    borderColor="gray.200"
                    borderRadius="md"
                    p="4"
                  >
                    <Text fontWeight="bold">{request.title}</Text>
                    <Text color="gray.600">{request.message}</Text>
                    <Text
                      mt="2"
                      color={
                        request.status === "Açık" ? "red.500" : "green.500"
                      }
                    >
                      {request.status}
                    </Text>

                    {request.status === "Açık" ? (
                      <Button
                        leftIcon={<FiMessageSquare />}
                        colorScheme="teal"
                        size="sm"
                        mt="2"
                      >
                        Yanıtla
                      </Button>
                    ) : null}
                  </Box>
                ))}
              </VStack>
            </VStack>
          </TabPanel>
          <TabPanel>
            <VStack spacing="4" w={350}>
              {!show && (
                <>
                  <Button
                    colorScheme="teal"
                    rightIcon={<IoCreateOutline />}
                    onClick={() => {
                      setShow(true);
                    }}
                  >
                    Yeni Talep Oluştur
                  </Button>
                </>
              )}

              {show && (
                <>
                  <Input
                    placeholder="Başlık"
                    value={memberTitle}
                    onChange={(e) => setMemberTitle(e.target.value)}
                  />
                  <Input
                    placeholder="Mesaj"
                    value={memberMessage}
                    onChange={(e) => setMemberMessage(e.target.value)}
                  />
                  <Button colorScheme="teal" onClick={handleSubmit}>
                    Gönder
                  </Button>
                </>
              )}
            </VStack>
            <Divider my="6" />

            <Heading mb="4">Önceki Talepler</Heading>
            <VStack spacing="4" align="start">
              {supportMemberRequests.map((request) => (
                <Box
                  key={request.id}
                  w="100%"
                  border="1px solid"
                  borderColor="gray.200"
                  borderRadius="md"
                  p="4"
                >
                  <Text fontWeight="bold">{request.title}</Text>
                  <Text color="gray.600">{request.message}</Text>
                </Box>
              ))}
            </VStack>
          </TabPanel>
        </TabPanels>
      </Tabs>
    </Box>
  );
};

export default SupportPage;
