import { Box, Flex } from "@chakra-ui/react";
import Head from "next/head";
import React, { useState } from "react";

import Navbar from "./components/Navbar";
import Sidebar from "./components/Sidebar";

function Layout({ children }) {
  const [isSidebarOpen, setIsSidebarOpen] = useState(false);

  const toggleSidebar = () => {
    setIsSidebarOpen(!isSidebarOpen);
  };
  return (
    <Flex as="main" zIndex="1">
      <Head>
        <meta name="robots" content="noindex, nofollow" />
        <link rel="icon" href="/favicon.ico" />
        <title>Library Managament</title>
      </Head>

      <Sidebar isOpen={isSidebarOpen} toggleSidebar={toggleSidebar} />
      <Box w="100%">
        <Navbar
          onMenuToggle={toggleSidebar}
          isOpen={isSidebarOpen}
          transition="0.3s ease-in-out"
        />

        <Box
          ml={isSidebarOpen ? "300px" : "0px"}
          mt={isSidebarOpen ? "20" : "20"}
          transition="margin-left 0.5s ease-in-out"
        >
          {children}
        </Box>
      </Box>
    </Flex>
  );
}

export default Layout