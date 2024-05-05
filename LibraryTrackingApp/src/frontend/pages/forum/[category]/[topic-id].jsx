import React from 'react';
import { useRouter } from 'next/router';

const TopicPage = () => {
  const router = useRouter();
  const { category, topicId } = router.query;

  return (
    <div>
      <h1>{category} Kategorisi - Konu #{topicId}</h1>
      <p>Bu sayfa {category} kategorisindeki #{topicId} numaralı konuyu gösterir.</p>
    </div>
  );
};

export default TopicPage;
