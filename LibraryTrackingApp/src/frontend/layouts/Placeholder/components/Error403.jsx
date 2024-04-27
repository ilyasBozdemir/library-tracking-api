// components/Error403.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error403 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>403 - Forbidden</Text>
      <Text fontSize="lg" mb={8}>Oops! You don't have permission to access this page.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error403;
