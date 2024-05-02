import React, { useState } from "react";
import { useFormik } from "formik";
import * as Yup from "yup";
import { NextSeo } from "next-seo";
import { useRouter } from "next/router";
import {
  Container,
  FormControl,
  FormLabel,
  Input,
  Stack,
  Button,
  Heading,
  useColorModeValue,
  VStack,
  Center,
  InputGroup,
  InputRightElement,
  Checkbox,
  Link as CLink,
  FormErrorMessage,
  IconButton,
  Text,
} from "@chakra-ui/react";
import { IoEyeOffOutline, IoEyeOutline } from "react-icons/io5";
import Link from "next/link";

// login endpointi ayarlana kadar şimdilik acık

const LoginPage = () => {
  const [show, setShow] = useState(false);
  const handleClick = () => setShow(!show);
  const router = useRouter();
  const formik = useFormik({
    initialValues: {
      username: "admin",
      password: "admin",
    },
    validationSchema: Yup.object({
      username: Yup.string().required("Kullanıcı adı zorunlu"),
      password: Yup.string().required("Şifre zorunlu"),
    }),
    onSubmit: (values) => {
      console.log("Giriş yapıldı:", values);
      router.push("/app");
    },
  });

  return (
    <>
      <NextSeo
        title="Giriş Yap"
        description="Kütüphane uygulamasına giriş yapın. Emanet kitaplarınızı yönetin ve okuma listelerinizi oluşturun."
      />
      <Container maxW="7xl" p={{ base: 5, md: 10 }}>
        <Center>
          <Stack spacing={4}>
            <Stack align="center">
              <Heading fontSize="2xl">Giriş Yap</Heading>
            </Stack>
            <VStack
              as="form"
              boxSize={{ base: "xs", sm: "sm", md: "md" }}
              h="max-content !important"
              bg={useColorModeValue("white", "gray.700")}
              rounded="lg"
              boxShadow="lg"
              p={{ base: 5, sm: 10 }}
              spacing={8}
              onSubmit={formik.handleSubmit}
            >
              <VStack spacing={4} w="100%">
                <FormControl
                  id="username"
                  isInvalid={formik.touched.username && formik.errors.username}
                >
                  <FormLabel>Kullanıcı Adı </FormLabel>
                  <Input
                    rounded="md"
                    type="text"
                    value={formik.values.username}
                    onChange={formik.handleChange}
                    onBlur={formik.handleBlur}
                  />
                  <FormErrorMessage>{formik.errors.username}</FormErrorMessage>
                </FormControl>
                <FormControl
                  id="password"
                  isInvalid={formik.touched.password && formik.errors.password}
                >
                  <FormLabel>Şifre</FormLabel>
                  <InputGroup size="md">
                    <Input
                      rounded="md"
                      type={show ? "text" : "password"}
                      name="password"
                      value={formik.values.password}
                      onChange={formik.handleChange}
                      onBlur={formik.handleBlur}
                    />
                    <InputRightElement width="4.5rem">
                      <IconButton
                        h="1.75rem"
                        size="sm"
                        rounded="md"
                        onClick={handleClick}
                        icon={show ? <IoEyeOffOutline /> : <IoEyeOutline />}
                      />
                    </InputRightElement>
                  </InputGroup>
                  <FormErrorMessage>{formik.errors.password}</FormErrorMessage>
                </FormControl>
              </VStack>
              <VStack w="100%">
                <Stack direction="row" justifyContent="space-between" w="100%">
                  <Checkbox colorScheme="teal" size="md">
                    Beni Hatırla
                  </Checkbox>
                  <CLink
                    as={Link}
                    href={"#"}
                    fontSize={{ base: "md", sm: "md" }}
                  >
                    Şifremi Unuttum
                  </CLink>
                </Stack>
                <Text fontSize="sm" mt={2} textAlign="center">
                  Giriş yaparak gizlilik sözleşmemizi kabul etmiş olursunuz.{" "}
                  <Link href="/privacy-policy" target={"_blank"}>
                    <Text color="teal.500">
                      Sözleşme metnine buradan ulaşabilirsiniz.
                    </Text>
                  </Link>
                </Text>
                <Button
                  type="submit"
                  colorScheme={"blue"}
                  rounded="md"
                  w="100%"
                >
                  Giriş Yap
                </Button>
              </VStack>
            </VStack>
          </Stack>
        </Center>

        <Text as="small" mt={5}>
          Not: herhangi bir username ve password ile girilebilir su an backende
          tam olarak baglanmamıstır.
        </Text>
      </Container>
    </>
  );
};

export default LoginPage;
