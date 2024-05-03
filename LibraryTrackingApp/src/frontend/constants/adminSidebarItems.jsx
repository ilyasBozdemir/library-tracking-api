import { BsBook, BsBuilding, BsPeople } from "react-icons/bs";
import { FiHome, FiSettings } from "react-icons/fi";
import { BiSupport } from "react-icons/bi";

export const adminSidebarItems = [
    {
      title: "Ana Sayfa",
      icon: <FiHome />,
      href: "/admin",
      target: "_self",
    },
    {
      title: "Kullanıcı Yönetimi",
      icon: <BsPeople />,
      href: "/admin/users",
      subItems: [
      
      ],
      target: "_self",
    },
    {
      title: "Kitap Yönetimi",
      icon: <BsBook />,
      href: "/admin/books",
      target: "_self",
    },
    {
      title: "Kütüphane Yönetimi",
      icon: <BsBuilding />,
      href: "/admin/libraries",
      target: "_self",
    },
    {
        title: "Destek",
        icon: <BiSupport />,
        href: "/admin/support",
        target: "_self",
      },
    {
      title: "Ayarlar",
      icon: <FiSettings />,
      href: "/admin/settings",
      target: "_self",
    },
  ];
  