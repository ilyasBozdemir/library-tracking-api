// components/Error500.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error500 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>500 - Internal Server Error</Text>
      <Text fontSize="lg" mb={8}>Oops! Something went wrong on the server.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error500;
