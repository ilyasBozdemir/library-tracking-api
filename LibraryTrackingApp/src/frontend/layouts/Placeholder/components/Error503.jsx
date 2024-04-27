// components/Error503.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error503 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>503 - Service Unavailable</Text>
      <Text fontSize="lg" mb={8}>Oops! The server is currently unavailable (overloaded or down).</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error503;
