import { FiHome, FiSettings, FiLogOut, FiBook } from "react-icons/fi";
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
import { BsFileEarmarkText, BsFillMicFill, BsNewspaper } from "react-icons/bs";
import { FaGraduationCap } from "react-icons/fa";

import { BiSupport } from "react-icons/bi";
import { IoCreateOutline } from "react-icons/io5";

import { CiBoxList } from "react-icons/ci";

export const sidebarItems = [
  {
    title: "Ana Sayfa",
    icon: <FiHome />,
    href: "/app",
    target: "_self",
    subItems: [],
  },
  {
    title: "Kütüphane Yönetimi",
    icon: <BsBuilding />,
    href: null,
    target: "_self",
    subItems: [
      {
        icon: <IoCreateOutline />,
        title: "Yeni Ekle",
        href: "/app/library/new",
        target: "_self",
      },
      {
        icon: <CiBoxList />,
        title: "Listele",
        href: "/app/library",
        target: "_self",
      },
    ],
  },
  {
    title: "Yazar Yönetimi",
    icon: <BsPerson />,
    href: null,
    target: "_self",
    subItems: [
      {
        icon: <IoCreateOutline />,
        title: "Yeni Ekle",
        href: "/app/author/new",
        target: "_self",
      },
      {
        icon: <CiBoxList />,
        title: "Listele",
        href: "/app/author",
        target: "_self",
      },
    ],
  },
  {
    title: "Eser Kataloğu",
    icon: <BsBook />,
    href: null,
    target: "_self",
    subItems: [
      {
        icon: <IoCreateOutline />,
        title: "Yeni Ekle",
        href: "/app/work-catalog/new",
        target: "_self",
      },
      {
        icon: <CiBoxList />,
        title: "Listele",
        href: "/app/work-catalog",
        target: "_self",
      },
    ],
  },
  {
    title: "Eser Envanter",
    icon: <BsBook />,
    href: null,
    target: "_self",
    subItems: [
      {
        title: "Basılı Kitap",
        icon: <BsBook />,
        href: "/app/printed-books",
        target: "_self",
      },
      {
        title: "E-Kitap",
        icon: <BsFileEarmarkText />,
        href: "/app/e-books",
        target: "_self",
      },
      {
        title: "Sesli Kitap",
        icon: <BsFillMicFill />,
        href: "/app/audio-books",
        target: "_self",
      },
      {
        title: "Dergi",
        icon: <BsNewspaper />,
        href: "/app/magazines",
        target: "_self",
      },
      {
        title: "Tez",
        icon: <FaGraduationCap />,
        href: "/app/thesis",
        target: "_self",
      },
    ],
  },
  {
    title: "Tür Yönetimi",
    icon: <FaBookOpen />,
    href: null,
    target: "_self",
    subItems: [
      {
        icon: <IoCreateOutline />,
        title: "Yeni  Ekle",
        href: "/app/genre/new",
        target: "_self",
      },
      {
        icon: <CiBoxList />,
        title: "Listele",
        href: "/app/genre",
        target: "_self",
      },
    ],
  },
  {
    title: "Üye Yönetimi",
    icon: <BsPeople />,
    href: "/app/members",
    target: "_self",
    subItems: [
      {
        icon: <IoCreateOutline />,
        title: "Yeni Ekle",
        href: "/app/members/new",
        target: "_self",
      },
      {
        icon: <CiBoxList />,
        title: "Listele",
        href: "/app/members",
        target: "_self",
      },
    ],
  },
  {
    title: "Personel Yönetimi",
    icon: <BsPeopleFill />,
    href: "/app/staff",
    target: "_self",
    subItems: [
      {
        icon: <IoCreateOutline />,
        title: "Yeni Ekle",
        href: "/app/staff/new",
        target: "_self",
      },
      {
        icon: <CiBoxList />,
        title: "Listele",
        href: "/app/staff",
        target: "_self",
      },
    ],
  },
  {
    title: "Ödünç Kitap Yönetimi",
    icon: <BsArrowLeftRight />,
    href: null,
    target: "_self",
    subItems: [
      {
        icon: <IoCreateOutline />,
        title: "Ödünç Ver",
        href: "/app/borrow/give",
        target: "_self",
      },
      {
        icon: <BsArrowLeftRight />,
        title: "İade Al/Teslim Al",
        href: "/app/borrow/return",
        target: "_self",
      },
      {
        icon: <IoCreateOutline />,
        title: "Uzatma İstekleri",
        href: "/app/borrow/extension-requests",
        target: "_self",
      },
      {
        icon: <CiBoxList />,
        title: "Ödünç Kitapları Listele",
        href: "/app/borrow",
        target: "_self",
      },
    ],
  },
  {
    title: "Kitap Etiket Yönetimi",
    icon: <BsTagFill />,
    href: null,
    target: "_self",
    subItems: [
      {
        icon: <IoCreateOutline />,
        title: "Yeni Ekle",
        href: "/app/book-tag/new",
        target: "_self",
      },
      {
        icon: <BsArrowLeftRight />,
        title: "Etiketleri Listele",
        href: "/app/book-tag",
        target: "_self",
      },
    ],
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
