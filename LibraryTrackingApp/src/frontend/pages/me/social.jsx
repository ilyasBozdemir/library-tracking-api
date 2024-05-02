import { Box, Button, Heading, Text, VStack } from "@chakra-ui/react";
import { FaComments, FaUsers } from "react-icons/fa";

const SocialInteractions = () => {
  return (
    <Box p={4} borderWidth="1px" borderRadius="md">
      <Heading as="h2" size="md" mb={4}>Sosyal Etkileşimler</Heading>
      <VStack spacing={4} align="stretch">
        <Box borderWidth="1px" borderRadius="md" p={4}>
          <Heading as="h3" size="sm" mb={2}>Forum ve Tartışma</Heading>
          <Text>Çeşitli konular hakkında tartışma başlatın veya katılın.</Text>
          <Button leftIcon={<FaComments />} colorScheme="blue" mt={2}>Tartışmalara Katıl</Button>
        </Box>
        <Box borderWidth="1px" borderRadius="md" p={4}>
          <Heading as="h3" size="sm" mb={2}>Okuma Grupları</Heading>
          <Text>Belirli bir kitabı birlikte okumak isteyen diğer üyelerle bir araya gelin.</Text>
          <Button leftIcon={<FaUsers />} colorScheme="green" mt={2}>Gruplara Katıl</Button>
        </Box>
      </VStack>
    </Box>
  );
};

export default SocialInteractions;
