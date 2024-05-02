import StatData from "@/layouts/Admin/components/Stats";
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
    <StatData/>
    </Box>
  );
};

export default AdminIndexPage;
