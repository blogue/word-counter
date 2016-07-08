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
      Counter c = new Counter();
      Assert.Equal(3, c.FindWord("the dog the dog the", "the"));
    }

  }
}
