// components/Error405.js

import { Box, Text, Button } from "@chakra-ui/react";
import Link from "next/link";

const Error405 = () => {
  return (
    <Box textAlign="center" mt={20}>
      <Text fontSize="3xl" fontWeight="bold" mb={4}>405 - Method Not Allowed</Text>
      <Text fontSize="lg" mb={8}>Oops! The method specified in the request is not allowed for the resource.</Text>
      <Link href="/">
        <Button colorScheme="blue" size="lg">Back to Home</Button>
      </Link>
    </Box>
  );
};

export default Error405;
