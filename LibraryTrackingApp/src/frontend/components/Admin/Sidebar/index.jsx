import {
  Box,
  Flex,
  VStack,
  Text,
  Avatar,
  Icon,
  Button,
  Divider,
} from "@chakra-ui/react";

import Link from "next/link";

import { CloseIcon } from "@chakra-ui/icons";
import { useRouter } from "next/router";
import { sidebarItems } from "@/constants/sidebarItems";

function Sidebar({ isOpen, toggleSidebar }) {
  const router = useRouter();

  return (
    <Box
      bg="gray.700"
      w="250px"
      h="100vh"
      p="4"
      position="fixed"
      left="0"
      top="0"
      overflowY="auto"
      transition="0.3s ease-in-out"
      transform={isOpen ? "translateX(0)" : "translateX(-250px)"}
      boxShadow="md"
      zIndex="2"
    >
      <Flex alignItems="center" mb="8">
        <Avatar size="sm" name="Admin" />
        <Text ml="3" fontSize="lg" fontWeight="bold" color="white">
          Admin Panel
        </Text>
        <Box ml="auto" onClick={toggleSidebar}>
          <CloseIcon
            boxSize={4}
            color="white"
            cursor={"pointer"}
            _hover={{ color: "red" }}
          />
        </Box>
      </Flex>
      <VStack spacing="4" align="stretch">
        {sidebarItems.map((item, index) => (
          <SidebarItem
            key={index}
            icon={item.icon}
            text={item.title}
            href={item.href}
            isActive={router.pathname === item.href}
          />
        ))}
      </VStack>
    </Box>
  );
}

const SidebarItem = ({ icon, text, href, isActive }) => {
  const color = isActive ? "#1468de" : "gray.100";

  return (
    <Link href={href} passHref>
      <Button
        variant="ghost"
        color={color}
        _hover={{ color: "#1468de" }}
        leftIcon={icon}
        justifyContent="flex-start"
      >
        {text}
      </Button>
    </Link>
  );
};

export default Sidebar;
