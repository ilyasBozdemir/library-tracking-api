import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error401 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>401 - Unauthorized</Text>
      <Text fontSize="lg" mb={8}>Oops! You are not authorized to access this page.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error401;