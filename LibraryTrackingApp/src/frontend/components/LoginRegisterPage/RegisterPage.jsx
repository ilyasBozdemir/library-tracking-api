import React from "react";
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
} from "@chakra-ui/react";
import { NextSeo } from "next-seo";

const RegisterPage = () => {
  const formik = useFormik({
    initialValues: {
      firstName: "admin",
      lastName: "admin",
      email: "employee1@example.com",
      phone: "5553334455",
      password: "YourPassword2",
    },
    validationSchema: Yup.object({
      firstName: Yup.string().required("Ad zorunlu"),
      lastName: Yup.string().required("Soyad zorunlu"),
      email: Yup.string()
        .email("Geçerli bir e-posta adresi girin")
        .required("E-posta zorunlu"),
      phone: Yup.string()
        .matches(/^\d{10}$/, "Geçerli bir telefon numarası girin")
        .required("Telefon zorunlu"),
      password: Yup.string()
        .min(6, "Şifre en az 6 karakter olmalı")
        .required("Şifre zorunlu"),
    }),
    onSubmit: (values) => {
      console.log("Kayıt yapıldı:", values);
    },
  });

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
                  id="firstName"
                  isInvalid={
                    formik.touched.firstName && formik.errors.firstName
                  }
                >
                  <FormLabel>Ad</FormLabel>
                  <Input
                    type="text"
                    name="firstName"
                    value={formik.values.firstName}
                    onChange={formik.handleChange}
                    onBlur={formik.handleBlur}
                  />
                  <FormErrorMessage>{formik.errors.firstName}</FormErrorMessage>
                </FormControl>
                <FormControl
                  id="lastName"
                  isInvalid={formik.touched.lastName && formik.errors.lastName}
                >
                  <FormLabel>Soyad</FormLabel>
                  <Input
                    type="text"
                    name="lastName"
                    value={formik.values.lastName}
                    onChange={formik.handleChange}
                    onBlur={formik.handleBlur}
                  />
                  <FormErrorMessage>{formik.errors.lastName}</FormErrorMessage>
                </FormControl>
              </Flex>

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
                id="phone"
                mt={4}
                isInvalid={formik.touched.phone && formik.errors.phone}
              >
                <FormLabel>Telefon</FormLabel>
                <Input
                  type="text"
                  name="phone"
                  value={formik.values.phone}
                  onChange={formik.handleChange}
                  onBlur={formik.handleBlur}
                />
                <FormErrorMessage>{formik.errors.phone}</FormErrorMessage>
              </FormControl>
              <FormControl
                id="password"
                mt={4}
                isInvalid={formik.touched.password && formik.errors.password}
              >
                <FormLabel>Şifre</FormLabel>
                <Input
                  type="password"
                  name="password"
                  value={formik.values.password}
                  onChange={formik.handleChange}
                  onBlur={formik.handleBlur}
                />
                <FormErrorMessage>{formik.errors.password}</FormErrorMessage>
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

export default RegisterPage;
