using Xunit;
using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class WordCounterTests
  {
    [Fact]
    public void Counter_thedogthedogthe_3()
    {
      RepeatCounter c = new RepeatCounter();
      Assert.Equal(3, c.CountRepeats("the dog the dog the", "the"));
    }

  }
}
