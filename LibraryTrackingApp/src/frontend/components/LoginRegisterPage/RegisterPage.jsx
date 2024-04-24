import React, { useEffect, useState } from "react";
import { useFormik } from "formik";
import * as Yup from "yup";
import {
  FormControl,
  FormLabel,
  Input,
  Button,
  FormErrorMessage,
  HStack,
  Stack,
  Flex,
  Center,
  VStack,
  Container,
  Heading,
  useColorModeValue,
  Box,
  useToast,
  InputGroup,
  InputRightElement,
  IconButton,
} from "@chakra-ui/react";
import { NextSeo } from "next-seo";
import AuthService from "@/services/authService";
import { IoEyeOffOutline, IoEyeOutline } from "react-icons/io5";

const RegisterPage = () => {
  const toast = useToast();

  // çalısıyor ama backende ki validotr ile burda ki validator kısmında tutarsızlıklar az cok mevcuttur düzeltilkcetir.
  //ne olursa olsun status code 200 dönmesi gerekiyor sunucudan
  // ama gelen json datası içinde gerçek status code dönerse daha tutarlı olucak.
  // backendde persistence içinde extensions/idendityextensions kısmında şifre ayarına göre. ayarlandı burası.

  const FormClear = (values) => {
    values.username = "";
    values.name = "";
    values.surname = "";
    values.email = "";
    values.telNumber = "";
    values.password = "";
  };

  const formik = useFormik({
    initialValues: {
      username: "",
      name: "",
      surname: "",
      email: "",
      telNumber: "",
      password: "",
      confirmPassword: "",
    },
    validationSchema: Yup.object({
      username: Yup.string()
        .required("Username zorunlu")
        .test(
          "username-exists",
          "Bu Kullanıcı adı zaten kullanılıyor.",
          async function (value) {
            const usernameExists = await AuthService.checkUsernameExists({
              UsernameOrEmail: value,
            });
            return !usernameExists;
          }
        ),
      name: Yup.string().required("Ad zorunlu"),
      surname: Yup.string().required("Soyad zorunlu"),
      email: Yup.string()
        .email("Geçerli bir e-posta adresi girin")
        .required("E-posta zorunlu")
        .test(
          "email-exists",
          "Bu e-posta adresi zaten kullanılıyor",
          async function (value) {
            const emailExists = await AuthService.checkEmailExists({
              UsernameOrEmail: value,
            });
            return !emailExists;
          }
        ),
      telNumber: Yup.string()
        .matches(/^\d{10}$/, "Geçerli bir telefon numarası girin")
        .required("Telefon zorunlu"),
      password: Yup.string()
        .min(5, "Şifre en az 5 karakter olmalı")
        .matches(/[a-zğüşıöç]/, "Şifre en az bir küçük harf içermeli")
        .matches(/[A-ZĞÜŞİÖÇ]/, "Şifre en az bir büyük harf içermeli")
        .matches(/[0-9]/, "Şifre en az bir rakam içermeli")
        .matches(
          /[_.\-!@#$%^&*(),.?":{}|<>]/,
          "Şifre en az bir özel karakter içermeli"
        )
        .test(
          "is-unique-chars",
          "Şifre en az 3 benzersiz karakter içermeli",
          (value) => {
            const uniqueChars = new Set(value);
            return uniqueChars.size >= 3;
          }
        )
        .required("Şifre zorunlu"),
      confirmPassword: Yup.string()
        .oneOf([Yup.ref("password"), null], "Şifreler eşleşmiyor")
        .required("Şifre doğrulama zorunludur"),
    }),

    onSubmit: async (values) => {
      var data = JSON.stringify(values, null, 2);
      var result = await AuthService.register(data);

      if (result.isSuccess === true) {
        FormClear(values);

        toast({
          title: "İşlem Başarılı",
          description: result.messages,
          status: "success",
          duration: 2500,
          isClosable: true,
        });
      } else {
        toast({
          title: "Hata",
          description: result.messages,
          status: "error",
          duration: 2500,
          isClosable: true,
        });
      }
    },
  });



  const [show, setShow] = useState(false);
  const handleClick = () => setShow(!show);
  return (
    <>
      <NextSeo
        title="Kayıt Ol"
        description="Kütüphane uygulamasına kayıt olun. Emanet kitaplarınızı yönetmeye başlayın ve favori kitaplarınızı ekleyin."
      />
      <Container maxW="7xl" p={{ base: 5, md: 10 }}>
        <Center>
          <Stack spacing={4}>
            <Stack align="center">
              <Heading fontSize="2xl">Kayıt Ol</Heading>
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
              <Flex direction="row" align="center" gap={2}>
                <FormControl
                  id="name"
                  isInvalid={formik.touched.name && formik.errors.name}
                >
                  <FormLabel>Ad</FormLabel>
                  <Input
                    type="text"
                    name="name"
                    value={formik.values.name}
                    onChange={formik.handleChange}
                    onBlur={formik.handleBlur}
                  />
                  <FormErrorMessage>{formik.errors.name}</FormErrorMessage>
                </FormControl>
                <FormControl
                  id="surname"
                  isInvalid={formik.touched.surname && formik.errors.surname}
                >
                  <FormLabel>Soyad</FormLabel>
                  <Input
                    type="text"
                    name="surname"
                    value={formik.values.surname}
                    onChange={formik.handleChange}
                    onBlur={formik.handleBlur}
                  />
                  <FormErrorMessage>{formik.errors.surname}</FormErrorMessage>
                </FormControl>
              </Flex>
              <FormControl
                id="username"
                mt={4}
                isInvalid={formik.touched.username && formik.errors.username}
              >
                <FormLabel>Username</FormLabel>
                <Input
                  type="text"
                  name="username"
                  value={formik.values.username}
                  onChange={formik.handleChange}
                  onBlur={formik.handleBlur}
                />
                <FormErrorMessage>{formik.errors.username}</FormErrorMessage>
              </FormControl>
              <FormControl
                id="email"
                mt={4}
                isInvalid={formik.touched.email && formik.errors.email}
              >
                <FormLabel>E-posta</FormLabel>
                <Input
                  type="email"
                  name="email"
                  value={formik.values.email}
                  onChange={formik.handleChange}
                  onBlur={formik.handleBlur}
                />
                <FormErrorMessage>{formik.errors.email}</FormErrorMessage>
              </FormControl>

              <FormControl
                id="telNumber"
                mt={4}
                isInvalid={formik.touched.telNumber && formik.errors.telNumber}
              >
                <FormLabel>Telefon</FormLabel>
                <Input
                  type="text"
                  name="telNumber"
                  value={formik.values.telNumber}
                  onChange={formik.handleChange}
                  onBlur={formik.handleBlur}
                />
                <FormErrorMessage>{formik.errors.telNumber}</FormErrorMessage>
              </FormControl>
              <FormControl
                id="password"
                isInvalid={formik.touched.password && formik.errors.password}
              >
                <FormLabel>Şifre</FormLabel>
                <InputGroup>
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
              <FormControl
                id="confirmPassword"
                isInvalid={
                  formik.touched.confirmPassword &&
                  formik.errors.confirmPassword
                }
              >
                <FormLabel>Şifre</FormLabel>
                <Input
                  rounded="md"
                  type={show ? "text" : "password"}
                  name="confirmPassword"
                  value={formik.values.confirmPassword}
                  onChange={formik.handleChange}
                  onBlur={formik.handleBlur}
                />
                <FormErrorMessage>
                  {formik.errors.confirmPassword}
                </FormErrorMessage>
              </FormControl>
              <Button type="submit" colorScheme="teal" w={"full"} mt={4}>
                Kayıt Ol
              </Button>
            </VStack>
          </Stack>
        </Center>
      </Container>
    </>
  );
};

const SuccessMessage = ({ children }) => (
  <Box color="green.500">{children}</Box>
);

export default RegisterPage;
