import React from 'react';
import { useFormik } from 'formik';
import * as Yup from 'yup';
import { FormControl, FormLabel, Input, Button, FormErrorMessage } from '@chakra-ui/react';

const LoginPage = () => {
  const formik = useFormik({
    initialValues: {
      username: '',
      password: '',
    },
    validationSchema: Yup.object({
      username: Yup.string().required('Kullanıcı adı zorunlu'),
      password: Yup.string().required('Şifre zorunlu'),
    }),
    onSubmit: values => {
      console.log('Giriş yapıldı:', values);
    },
  });

  return (
    <form onSubmit={formik.handleSubmit}>
      <FormControl id="username" isInvalid={formik.touched.username && formik.errors.username}>
        <FormLabel>Kullanıcı Adı</FormLabel>
        <Input type="text" name="username" value={formik.values.username} onChange={formik.handleChange} onBlur={formik.handleBlur} />
        <FormErrorMessage>{formik.errors.username}</FormErrorMessage>
      </FormControl>
      <FormControl id="password" mt={4} isInvalid={formik.touched.password && formik.errors.password}>
        <FormLabel>Şifre</FormLabel>
        <Input type="password" name="password" value={formik.values.password} onChange={formik.handleChange} onBlur={formik.handleBlur} />
        <FormErrorMessage>{formik.errors.password}</FormErrorMessage>
      </FormControl>
      <Button type="submit" colorScheme="blue" mt={4}>Giriş Yap</Button>
    </form>
  );
};

export default LoginPage;
