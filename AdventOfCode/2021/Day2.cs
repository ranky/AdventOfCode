﻿//using AdventOfCode2022.Day.X;

namespace AdventOfCode.Execution._2021;

public class Day2 : AdventOfCodeExecutionBase
{
    public Day2(ITestOutputHelper output) : base(output)
    {
    }

    [Theory]
    [InlineData(@"", null)]
    public void Part1_Validation(string input, object expectedValue)
    {
    }

    [Theory]
    [InlineData(@"", null)]
    public void Part2_Validation(string input, object expectedValue)
    {        
    }

    [Fact]
    public async void Part1_Execution()
    {
        await Solve((lines) =>
        {
            return default(object);
        });
    }

    [Fact]
    public async void Part2_Execution()
    {
        await Solve<object>((lines) =>
        {
            return default(object);
        });
    }
}