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
        <Box key={index}>
          <SidebarItem
            icon={item.icon}
            text={item.title}
            href={item.href}
            target={item.target}
            isActive={router.pathname === item.href}
          />
          {sidebarItems.subItems && item.subItems.length > 0 && (
            <VStack spacing="1" align="stretch" ml="4">
              {item.subItems.map((subItem, subIndex) => (
                <SidebarItem
                  key={subIndex}
                  icon={subItem.icon}
                  text={subItem.title}
                  href={subItem.href}
                  target={subItem.target}
                  isActive={router.pathname === subItem.href}
                  isSubItem
                />
              ))}
            </VStack>
          )}
        </Box>
      ))}
    </VStack>
    </Box>
  );
}


const SidebarItem = ({ icon, text, href, target, isActive }) => {
  const color = isActive ? "#1468de" : "gray.100";
  return (
    <Link href={href} target={target} passHref>
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
