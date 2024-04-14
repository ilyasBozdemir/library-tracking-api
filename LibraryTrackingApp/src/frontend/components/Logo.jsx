import { Box, useColorMode } from "@chakra-ui/react";
import Link from "next/link";
import React from "react";
import LogoSVG from "./LogoSVG";

function Logo({ from = "header" }) {
  const { colorMode } = useColorMode();

  const colorN = colorMode === "dark" ? "white" : "red";

  return (
    <>
      <Link href="/">
        {from === "footer" ? (
          <>
            <LogoSVG width="100px" height="100px" svgColor={colorN} />
          </>
        ) : (
          <>
            <LogoSVG width={"60px"} height={"50px"} svgColor={colorN} />
          </>
        )}
      </Link>
    </>
  );
}

export default Logo;
