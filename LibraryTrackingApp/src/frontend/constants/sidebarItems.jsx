import { FiHome, FiSettings, FiLogOut, FiBook, FiHelpCircle } from "react-icons/fi";
import {
  BsArrowLeftRight,
  BsBook,
  BsBuilding,
  BsPeople,
  BsPeopleFill,
  BsPerson,
  BsTagFill,
} from "react-icons/bs";
import { FaBookOpen } from "react-icons/fa";

import { BiSupport } from "react-icons/bi";

export const sidebarItems = [
  {
    title: "Ana Sayfa",
    icon: <FiHome />,
    href: "/app",
    target: "_self",
  },
  {
    title: "Kütüphane Yönetimi",
    icon: <BsBuilding />,
    href: "/app/library",
    target: "_self",
  },
  {
    title: "Yazar Yönetimi",
    icon: <BsPerson />,
    href: "/app/author",
    target: "_self",
  },
  { title: "Kitaplar", icon: <BsBook />, href: "/app/book", target: "_self" },
  {
    title: "Kitap Tür Yönetimi",
    icon: <FaBookOpen />,
    href: "/app/genre",
    target: "_self",
  },
  {
    title: "Kütüphane Üye Yönetimi",
    icon: <BsPeople />,
    href: "/app/member",
    target: "_self",
  },
  {
    title: "Personel Yönetimi",
    icon: <BsPeopleFill />,
    href: "/app/staff",
    target: "_self",
  },
  {
    title: "Ödünç Kitap Yönetimi",
    icon: <BsArrowLeftRight />,
    href: "/app/borrow",
    target: "_self",
  },
  {
    title: "Kitap Etiket Yönetimi",
    icon: <BsTagFill />,
    href: "/app/book-tag",
    target: "_self",
  },
  {
    title: "Ayarlar",
    icon: <FiSettings />,
    href: "/app/settings",
    target: "_self",
  },
  {
    title: "Geliştirici Belgeleri",
    icon: <FiBook />,
    href: "/docs",
    target: "_blank",
  },
  {
    title: "Destek",
    icon: <BiSupport />,
    href: "/app/support",
    target: "_self",
  },
  {
    title: "Çıkış Yap",
    icon: <FiLogOut />,
    href: "/app/logout",
    target: "_self",
  },
];

export const items = [
  {
    title: "Kütüphane",
    description: "Kütüphane bilgilerini düzenleyin, yeni kütüphaneler ekleyin.",
    link: "/app/library",
  },
  {
    title: "Üyeler",
    description: "Üyeleri yönetin, yeni üyeler ekleyin.",
    link: "/app/member",
  },
  {
    title: "Kitaplar",
    description: "Kitapları düzenleyin, yeni kitaplar ekleyin.",
    link: "/app/book",
  },
  {
    title: "Personel",
    description: "Personel bilgilerini yönetin, yeni personel ekleyin.",
    link: "/app/staff",
  },
  {
    title: "Ödünç Verme",
    description: "Kitap ödünç verme işlemlerini yönetin.",
    link: "/app/borrow",
  },
  {
    title: "Kitap Türleri",
    description: "Kitap türlerini düzenleyin, yeni türler ekleyin.",
    link: "/app/genre",
  },
  {
    title: "Kitap Etiketleri",
    description:
      "Arama terimlerini yönetin, popüler arama terimlerini görüntüleyin ve düzenleyin.",
    link: "/app/book-tag",
  },
];
