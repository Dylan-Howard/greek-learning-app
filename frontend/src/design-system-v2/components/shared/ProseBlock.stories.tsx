import type { Meta, StoryObj } from '@storybook/react';
import React from 'react';
import { ProseBlock } from './ProseBlock';

const meta = {
  title: 'Design System/Shared/ProseBlock',
  component: ProseBlock,
  args: {
    children: (
      <>
        <h2>Reading Notes</h2>
        <p>
          The Greek text often uses participles to convey nuance. Pay attention to
          how the clause structure shifts between narrative and instruction.
        </p>
        <ul>
          <li>Mark repeated verbs and their tense.</li>
          <li>Note vocabulary with high SRS difficulty.</li>
        </ul>
        <p>
          For more details, see <a href="https://example.com">the reference guide</a>.
        </p>
      </>
    ),
  },
} satisfies Meta<typeof ProseBlock>;

export default meta;
type Story = StoryObj<typeof meta>;

export const Default: Story = {};
