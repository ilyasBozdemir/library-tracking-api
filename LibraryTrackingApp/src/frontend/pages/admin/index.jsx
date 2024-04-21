import { Box, Flex, Heading, VStack, Text, Badge, HStack } from "@chakra-ui/react";
import { FiUsers, FiBook, FiMapPin, FiClock } from "react-icons/fi";

const AdminIndexPage = () => {
  const todayActivities = {
    newUsers: 5,
    newBooks: 10,
    newLibraries: 2,
    newLocations: 3,
    newWorkingHours: 15,
  };

  return (
    <Box p="6">
      <Heading mb="4">Admin Paneli Ana Sayfa</Heading>
      <VStack spacing="4" align="start">
        <Flex align="center">
          <Box as={FiUsers} fontSize="2xl" color="teal.500" mr="2" />
          <Box>
            <Text fontWeight="bold">Yeni Kullanıcılar</Text>
            <Text>{todayActivities.newUsers}</Text>
          </Box>
        </Flex>
        <Flex align="center">
          <Box as={FiBook} fontSize="2xl" color="teal.500" mr="2" />
          <Box>
            <Text fontWeight="bold">Yeni Kitaplar</Text>
            <Text>{todayActivities.newBooks}</Text>
          </Box>
        </Flex>
        <Flex align="center">
          <Box as={FiMapPin} fontSize="2xl" color="teal.500" mr="2" />
          <Box>
            <Text fontWeight="bold">Yeni Konumlar</Text>
            <Text>{todayActivities.newLocations}</Text>
          </Box>
        </Flex>
        <Flex align="center">
          <Box as={FiClock} fontSize="2xl" color="teal.500" mr="2" />
          <Box>
            <Text fontWeight="bold">Yeni Çalışma Saatleri</Text>
            <Text>{todayActivities.newWorkingHours}</Text>
          </Box>
        </Flex>
      </VStack>
    </Box>
  );
};

export default AdminIndexPage;
