import {
  Box,
  Flex,
  VStack,
  Text,
  Avatar,
  Icon,
  Button,
} from "@chakra-ui/react";
import { FiHome, FiSettings, FiLogOut } from "react-icons/fi";
import {
  BsArrowLeftRight,
  BsBook,
  BsBuilding,
  BsPeople,
  BsPeopleFill,
  BsPerson,
  BsTagFill,
} from "react-icons/bs";
import Link from "next/link";
import { FaBookOpen } from "react-icons/fa";
import { CloseIcon } from "@chakra-ui/icons";

function Sidebar({ isOpen ,toggleSidebar}) {
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
        <Avatar size="sm" name="Admin" src="https://avatars.githubusercontent.com/u/52322835?s=96&v=4" />
        <Text ml="3" fontSize="lg" fontWeight="bold" color="white">
          Admin Panel
        </Text>
        <Box ml="auto" onClick={toggleSidebar}>
          <CloseIcon boxSize={4} color="white" cursor={'pointer'} _hover={{color:'red'}}/>
        </Box>
      </Flex>
      <VStack spacing="4" align="stretch">
        <SidebarItem icon={<FiHome />} text="Ana Sayfa" href="/admin" />
        <SidebarItem
          icon={<BsBuilding />}
          text="Şubeler"
          href="/admin/branches"
        />
        <SidebarItem
          icon={<BsPerson />}
          text="Yazarlar"
          href="/admin/authors"
        />
        <SidebarItem icon={<BsBook />} text="Kitaplar" href="/admin/books" />
        <SidebarItem icon={<FaBookOpen />} text="Türler" href="/admin/genres" />
        <SidebarItem icon={<BsPeople />} text="Üyeler" href="/admin/members" />
        <SidebarItem
          icon={<BsPeopleFill />}
          text="Çalışanlar"
          href="/admin/staffs"
        />
        <SidebarItem
          icon={<BsArrowLeftRight />}
          text="Ödünç Verilen Kitaplar"
          href="/admin/borrows"
        />

        <SidebarItem
          icon={<BsTagFill />}
          text="Etiketler"
          href="/admin/book-tags"
        />
        <SidebarItem
          icon={<FiSettings />}
          text="Ayarlar"
          href="/admin/settings"
        />
        <SidebarItem
          icon={<FiLogOut />}
          text="Çıkış Yap"
          href="/admin/logout"
        />
      </VStack>
    </Box>
  );
}

const SidebarItem = ({ icon, text, href }) => {
  return (
    <Link href={href} passHref>
      <Button
        variant="ghost"
        color="white"
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
