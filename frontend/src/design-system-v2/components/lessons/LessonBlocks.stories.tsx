import type { Meta, StoryObj } from '@storybook/react';
import React, { useState } from 'react';
import {
  TextBlock,
  ImageBlock,
  VideoBlock,
  ConfirmCheckbox,
  MultipleChoice,
  TextInputQuestion,
} from './LessonBlocks';

const meta = {
  title: 'Design System/Lessons/LessonBlocks',
  component: TextBlock,
  args: {
    content: 'Sample lesson content.',
  },
} satisfies Meta<typeof TextBlock>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Text: Story = {
  args: {
    content: 'The Greek word <span class="greek">λόγος</span> can mean "word" or "reason."',
  },
};

export const Image: Story = {
  render: () => (
    <ImageBlock
      src="/koine-logo.svg"
      alt="Koine logo"
      caption="Koine symbol"
    />
  ),
};

export const Video: Story = {
  render: () => (
    <VideoBlock
      src="https://www.youtube.com/embed/dQw4w9WgXcQ"
      title="Lesson video"
    />
  ),
};

export const Confirm: Story = {
  render: () => {
    const [checked, setChecked] = useState(false);
    return (
      <ConfirmCheckbox
        id="confirm-1"
        checked={checked}
        onChange={(_, next) => setChecked(next)}
      />
    );
  },
};

export const MultipleChoiceQuestion: Story = {
  render: () => (
    <MultipleChoice
      id="mc-1"
      question="Which word means 'love'?"
      options={[
        { id: 'a', text: 'ἀγάπη' },
        { id: 'b', text: 'λόγος' },
        { id: 'c', text: 'ἀλήθεια' },
      ]}
      correctId="a"
      onAnswer={() => {}}
    />
  ),
};

export const TextInput: Story = {
  render: () => (
    <TextInputQuestion
      id="ti-1"
      question="Type the Greek word for 'life'"
      answer="ζωή"
      onAnswer={() => {}}
    />
  ),
};
