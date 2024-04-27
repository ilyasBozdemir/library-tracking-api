// components/Error402.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error402 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>402 - Payment Required</Text>
      <Text fontSize="lg" mb={8}>Oops! Payment is required to access this resource.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error402;
