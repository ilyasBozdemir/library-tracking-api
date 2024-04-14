import React from "react";
import { useTranslation } from "next-i18next";
import {
  Box,
  Text,
  Link,
  MenuItem,
  useDisclosure,
  useColorModeValue,
} from "@chakra-ui/react";

import { useAppContext } from "@/contexts/AppContext";
import Logo from "./Logo";

export default function Header() {
  const { isOpen, onOpen, onClose } = useDisclosure();

  return (
    <Box px={4} bg={useColorModeValue("white", "gray.800")} color={"primary"}>
      <Logo />
    </Box>
  );
}
