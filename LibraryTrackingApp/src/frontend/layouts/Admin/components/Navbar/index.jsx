import { useState } from "react";
import {
  Box,
  Avatar,
  Button,
  HStack,
  VStack,
  Menu,
  MenuButton,
  MenuList,
  MenuItem,
  Text,
  useColorModeValue,
  Icon,
  Flex,
} from "@chakra-ui/react";
import Link from "next/link";
import ThemeSwitcher from "../../../../components/ThemeSwitcher";
import LanguageSwitcher from "../../../../components/LanguageSwitcher";

import { FiMinimize, FiMaximize } from "react-icons/fi";
import { HiMenuAlt2 } from "react-icons/hi";

const Navbar = ({ isOpen, onMenuToggle }) => {
  const [isMaximized, setIsMaximized] = useState(false);

  const handleMaximizeToggle = () => {
    setIsMaximized(!isMaximized);

    if (!isMaximized) {
      // Pencere tam ekran yapılabilir
      if (document.documentElement.requestFullscreen) {
        document.documentElement.requestFullscreen();
      } else if (document.documentElement.mozRequestFullScreen) {
        document.documentElement.mozRequestFullScreen();
      } else if (document.documentElement.webkitRequestFullscreen) {
        document.documentElement.webkitRequestFullscreen();
      } else if (document.documentElement.msRequestFullscreen) {
        document.documentElement.msRequestFullscreen();
      }
    } else {
      // Tam ekranı kapat
      if (document.exitFullscreen) {
        document.exitFullscreen();
      } else if (document.mozCancelFullScreen) {
        document.mozCancelFullScreen();
      } else if (document.webkitExitFullscreen) {
        document.webkitExitFullscreen();
      } else if (document.msExitFullscreen) {
        document.msExitFullscreen();
      }
    }
  };

  return (
    <Flex
    boxShadow="sm"
    border="0 solid #e5e7eb"
    bg={useColorModeValue("gray.100", "gray.700")}
    justifyContent={"space-between"}
    p={2}
    zIndex={15}
    width={isOpen ? "calc(100% - 275px)" : "100%"}
    transform={isOpen ? "translateX(275px)" : "translateX(0)"}
     transition="0.3s ease-in"
    >
      <HStack spacing={3}>
        <Icon
          cursor={"pointer"}
          as={HiMenuAlt2}
          boxSize={18}
          onClick={onMenuToggle}
        />
      </HStack>

      <NavItem
        isMaximized={isMaximized}
        handleMaximizeToggle={handleMaximizeToggle}
      />
    </Flex>
  );
};

const NavItem = ({ isMaximized, handleMaximizeToggle }) => {
  return (
    <>
      <HStack spacing={3}>
        <LanguageSwitcher />
        <ThemeSwitcher />

        <Icon
          cursor={"pointer"}
          as={isMaximized ? FiMinimize : FiMaximize}
          boxSize={15}
          onClick={handleMaximizeToggle}
        />

        <Menu isLazy>
          <MenuButton as={Button} size="sm" _hover={{ variant: "ghost" }}>
            <Avatar
              size="sm"
              src={"https://avatars.githubusercontent.com/u/52322835?s=96&v=4"}
            />
          </MenuButton>
          <MenuList
            zIndex={5}
            border="2px solid"
            borderColor={useColorModeValue("gray.100", "gray.700")}
            boxShadow="4px 4px 0"
          >
            <Link href="/admin/profile" passHref>
              <MenuItem>
                <VStack justify="start" alignItems="left">
                  <Text fontWeight="500">İlyas Bozdemir</Text>
                  <Text size="sm" color="gray.500" mt="0 !important">
                    @ilyasbozdemir
                  </Text>
                </VStack>
              </MenuItem>
            </Link>
          </MenuList>
        </Menu>
      </HStack>
    </>
  );
};

export default Navbar;
