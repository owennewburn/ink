﻿
namespace Inklewriter.Runtime
{
    public class ControlCommand : Runtime.Object
    {
        public enum CommandType
        {
            EvalStart,
            EvalOutput,
            EvalEnd,
            StackPush,
            StackPop,
            Duplicate,
            PopEvaluatedValue,
            NoOp,
            ChoiceCount,
            VisitIndex,
            SequenceShuffleIndex
        }

        public CommandType commandType { get; protected set; }

        public ControlCommand (CommandType commandType)
        {
            this.commandType = commandType;
        }

        public static ControlCommand EvalStart() {
            return new ControlCommand(CommandType.EvalStart);
        }

        public static ControlCommand EvalOutput() {
            return new ControlCommand(CommandType.EvalOutput);
        }

        public static ControlCommand EvalEnd() {
            return new ControlCommand(CommandType.EvalEnd);
        }

        public static ControlCommand StackPush() {
            return new ControlCommand(CommandType.StackPush);
        }

        public static ControlCommand StackPop() {
            return new ControlCommand(CommandType.StackPop);
        }

        public static ControlCommand Duplicate() {
            return new ControlCommand(CommandType.Duplicate);
        }

        public static ControlCommand PopEvaluatedValue() {
            return new ControlCommand (CommandType.PopEvaluatedValue);
        }

        public static ControlCommand NoOp() {
            return new ControlCommand(CommandType.NoOp);
        }

        public static ControlCommand ChoiceCount() {
            return new ControlCommand(CommandType.ChoiceCount);
        }

        public static ControlCommand VisitIndex() {
            return new ControlCommand(CommandType.VisitIndex);
        }
            
        public static ControlCommand SequenceShuffleIndex() {
            return new ControlCommand(CommandType.SequenceShuffleIndex);
        }

        public override string ToString ()
        {
            return commandType.ToString();
        }
    }
}

