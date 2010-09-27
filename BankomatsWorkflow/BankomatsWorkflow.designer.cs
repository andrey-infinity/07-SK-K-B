using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace BankomatWorkflowLibrary
{
    partial class BankomatsWorkflow
    {
		#region Designer generated code
        
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding3 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding4 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding5 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding6 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding7 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding8 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference2 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference3 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference4 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference5 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference6 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference7 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference8 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference9 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference10 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference11 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference12 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference13 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference14 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding9 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding10 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding11 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding12 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding13 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding14 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference15 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding15 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            this.setStateActivity3 = new System.Workflow.Activities.SetStateActivity();
            this.AuthFailed = new System.Workflow.Activities.CallExternalMethodActivity();
            this.SetMenuState = new System.Workflow.Activities.SetStateActivity();
            this.ifElseBranchActivity2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.callExternalMethodActivity7 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.setStateActivity10 = new System.Workflow.Activities.SetStateActivity();
            this.callExternalMethodActivity11 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.codeActivity2 = new System.Workflow.Activities.CodeActivity();
            this.callExternalMethodActivity12 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.callExternalMethodActivity2 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.callExternalMethodActivity3 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.callExternalMethodActivity5 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.setStateActivity9 = new System.Workflow.Activities.SetStateActivity();
            this.ViewCurrentCardNumber = new System.Workflow.Activities.CallExternalMethodActivity();
            this.SetSelectLanguageState = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
            this.ExitFromBalance = new System.Workflow.Activities.SetStateActivity();
            this.ViewCurrentPin = new System.Workflow.Activities.CallExternalMethodActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.setStateActivity8 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity4 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity5 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity8 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity7 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity7 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity6 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity5 = new System.Workflow.Activities.CodeActivity();
            this.ifElseBranchActivity13 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity12 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity11 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity10 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity9 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity6 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity5 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity8 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity7 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity4 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifElseBranchActivity3 = new System.Workflow.Activities.IfElseBranchActivity();
            this.cancellationHandlerActivity1 = new System.Workflow.ComponentModel.CancellationHandlerActivity();
            this.compensatableSequenceActivity5 = new System.Workflow.Activities.CompensatableSequenceActivity();
            this.compensatableSequenceActivity4 = new System.Workflow.Activities.CompensatableSequenceActivity();
            this.compensatableSequenceActivity3 = new System.Workflow.Activities.CompensatableSequenceActivity();
            this.compensatableSequenceActivity2 = new System.Workflow.Activities.CompensatableSequenceActivity();
            this.compensatableSequenceActivity1 = new System.Workflow.Activities.CompensatableSequenceActivity();
            this.ifElseActivity5 = new System.Workflow.Activities.IfElseActivity();
            this.handleExternalEventActivity3 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.callExternalMethodActivity6 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.ifElseActivity4 = new System.Workflow.Activities.IfElseActivity();
            this.handleExternalEventActivity2 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.callExternalMethodActivity4 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.callExternalMethodActivity10 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.callExternalMethodActivity8 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.ReadCardIfElse = new System.Workflow.Activities.IfElseActivity();
            this.ReadCardNumber = new System.Workflow.Activities.HandleExternalEventActivity();
            this.DisplayWelcomeMessage = new System.Workflow.Activities.CallExternalMethodActivity();
            this.InitCode = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity3 = new System.Workflow.Activities.IfElseActivity();
            this.handleExternalEventActivity1 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.callExternalMethodActivity9 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.ifElseActivity2 = new System.Workflow.Activities.IfElseActivity();
            this.GetPinHandle = new System.Workflow.Activities.HandleExternalEventActivity();
            this.callExternalMethodActivity1 = new System.Workflow.Activities.CallExternalMethodActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.conditionedActivityGroup1 = new System.Workflow.Activities.ConditionedActivityGroup();
            this.GetActionToDo = new System.Workflow.Activities.HandleExternalEventActivity();
            this.ViewMenuText = new System.Workflow.Activities.CallExternalMethodActivity();
            this.SetAuthState = new System.Workflow.Activities.SetStateActivity();
            this.GetLanguageHandle = new System.Workflow.Activities.HandleExternalEventActivity();
            this.ViewLanguageMenu = new System.Workflow.Activities.CallExternalMethodActivity();
            this.eventDrivenActivity2 = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity3 = new System.Workflow.Activities.StateInitializationActivity();
            this.eventDrivenActivity1 = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity2 = new System.Workflow.Activities.StateInitializationActivity();
            this.handleExternalEventActivity5 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.handleExternalEventActivity6 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.stateInitializationActivity7 = new System.Workflow.Activities.StateInitializationActivity();
            this.stateInitializationActivity5 = new System.Workflow.Activities.StateInitializationActivity();
            this.EnterCardEvent = new System.Workflow.Activities.EventDrivenActivity();
            this.Init = new System.Workflow.Activities.StateInitializationActivity();
            this.MenuOrExit = new System.Workflow.Activities.EventDrivenActivity();
            this.InitBalace = new System.Workflow.Activities.StateInitializationActivity();
            this.GetPin = new System.Workflow.Activities.EventDrivenActivity();
            this.InitAuth = new System.Workflow.Activities.StateInitializationActivity();
            this.stateInitializationActivity1 = new System.Workflow.Activities.StateInitializationActivity();
            this.SelectActionToDo = new System.Workflow.Activities.EventDrivenActivity();
            this.InitMenu = new System.Workflow.Activities.StateInitializationActivity();
            this.GetLanguage = new System.Workflow.Activities.EventDrivenActivity();
            this.InitLanguage = new System.Workflow.Activities.StateInitializationActivity();
            this.EnterNewPin = new System.Workflow.Activities.StateActivity();
            this.EnterOldPin = new System.Workflow.Activities.StateActivity();
            this.NumHandler = new System.Workflow.Activities.EventDrivenActivity();
            this.ActionHandler = new System.Workflow.Activities.EventDrivenActivity();
            this.Deposit = new System.Workflow.Activities.StateActivity();
            this.Withdrawal = new System.Workflow.Activities.StateActivity();
            this.EnterCard = new System.Workflow.Activities.StateActivity();
            this.ViewBalance = new System.Workflow.Activities.StateActivity();
            this.Authenticate = new System.Workflow.Activities.StateActivity();
            this.Final = new System.Workflow.Activities.StateActivity();
            this.Menu = new System.Workflow.Activities.StateActivity();
            this.SelectLanguage = new System.Workflow.Activities.StateActivity();
            // 
            // setStateActivity3
            // 
            this.setStateActivity3.Name = "setStateActivity3";
            this.setStateActivity3.TargetStateName = "Final";
            // 
            // AuthFailed
            // 
            this.AuthFailed.InterfaceType = typeof(Interfaces.IFormService);
            this.AuthFailed.MethodName = "AuthFailed";
            this.AuthFailed.Name = "AuthFailed";
            // 
            // SetMenuState
            // 
            this.SetMenuState.Name = "SetMenuState";
            this.SetMenuState.TargetStateName = "Menu";
            // 
            // ifElseBranchActivity2
            // 
            this.ifElseBranchActivity2.Activities.Add(this.AuthFailed);
            this.ifElseBranchActivity2.Activities.Add(this.setStateActivity3);
            this.ifElseBranchActivity2.Name = "ifElseBranchActivity2";
            // 
            // ifElseBranchActivity1
            // 
            this.ifElseBranchActivity1.Activities.Add(this.SetMenuState);
            ruleconditionreference1.ConditionName = "IsAuth";
            this.ifElseBranchActivity1.Condition = ruleconditionreference1;
            this.ifElseBranchActivity1.Name = "ifElseBranchActivity1";
            // 
            // callExternalMethodActivity7
            // 
            this.callExternalMethodActivity7.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity7.MethodName = "SendBackMessage";
            this.callExternalMethodActivity7.Name = "callExternalMethodActivity7";
            activitybind1.Name = "BankomatsWorkflow";
            activitybind1.Path = "newPIN";
            workflowparameterbinding1.ParameterName = "message";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.callExternalMethodActivity7.ParameterBindings.Add(workflowparameterbinding1);
            // 
            // setStateActivity10
            // 
            this.setStateActivity10.Name = "setStateActivity10";
            this.setStateActivity10.TargetStateName = "Menu";
            // 
            // callExternalMethodActivity11
            // 
            this.callExternalMethodActivity11.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity11.MethodName = "SendBackMessageLine";
            this.callExternalMethodActivity11.Name = "callExternalMethodActivity11";
            workflowparameterbinding2.ParameterName = "message";
            workflowparameterbinding2.Value = "\"Ja pomenjal pin\"";
            this.callExternalMethodActivity11.ParameterBindings.Add(workflowparameterbinding2);
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.codeActivity2_ExecuteCode_1);
            // 
            // callExternalMethodActivity12
            // 
            this.callExternalMethodActivity12.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity12.MethodName = "SendBackMessage";
            this.callExternalMethodActivity12.Name = "callExternalMethodActivity12";
            activitybind2.Name = "BankomatsWorkflow";
            activitybind2.Path = "newPIN";
            workflowparameterbinding3.ParameterName = "message";
            workflowparameterbinding3.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.callExternalMethodActivity12.ParameterBindings.Add(workflowparameterbinding3);
            // 
            // callExternalMethodActivity2
            // 
            this.callExternalMethodActivity2.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity2.MethodName = "SendBackMessage";
            this.callExternalMethodActivity2.Name = "callExternalMethodActivity2";
            workflowparameterbinding4.ParameterName = "message";
            workflowparameterbinding4.Value = "\"Ti sosew\"";
            this.callExternalMethodActivity2.ParameterBindings.Add(workflowparameterbinding4);
            // 
            // callExternalMethodActivity3
            // 
            this.callExternalMethodActivity3.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity3.MethodName = "SendBackMessage";
            this.callExternalMethodActivity3.Name = "callExternalMethodActivity3";
            activitybind3.Name = "BankomatsWorkflow";
            activitybind3.Path = "oldPIN";
            workflowparameterbinding5.ParameterName = "message";
            workflowparameterbinding5.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.callExternalMethodActivity3.ParameterBindings.Add(workflowparameterbinding5);
            // 
            // callExternalMethodActivity5
            // 
            this.callExternalMethodActivity5.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity5.MethodName = "SendBackMessage";
            this.callExternalMethodActivity5.Name = "callExternalMethodActivity5";
            activitybind4.Name = "BankomatsWorkflow";
            activitybind4.Path = "oldPIN";
            workflowparameterbinding6.ParameterName = "message";
            workflowparameterbinding6.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.callExternalMethodActivity5.ParameterBindings.Add(workflowparameterbinding6);
            // 
            // setStateActivity9
            // 
            this.setStateActivity9.Name = "setStateActivity9";
            this.setStateActivity9.TargetStateName = "EnterNewPin";
            // 
            // ViewCurrentCardNumber
            // 
            this.ViewCurrentCardNumber.InterfaceType = typeof(Interfaces.IFormService);
            this.ViewCurrentCardNumber.MethodName = "SendBackMessage";
            this.ViewCurrentCardNumber.Name = "ViewCurrentCardNumber";
            activitybind5.Name = "BankomatsWorkflow";
            activitybind5.Path = "currentAccountNumber";
            workflowparameterbinding7.ParameterName = "message";
            workflowparameterbinding7.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.ViewCurrentCardNumber.ParameterBindings.Add(workflowparameterbinding7);
            // 
            // SetSelectLanguageState
            // 
            this.SetSelectLanguageState.Name = "SetSelectLanguageState";
            this.SetSelectLanguageState.TargetStateName = "SelectLanguage";
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "Menu";
            // 
            // ExitFromBalance
            // 
            this.ExitFromBalance.Name = "ExitFromBalance";
            this.ExitFromBalance.TargetStateName = "Final";
            // 
            // ViewCurrentPin
            // 
            this.ViewCurrentPin.InterfaceType = typeof(Interfaces.IFormService);
            this.ViewCurrentPin.MethodName = "SendBackMessage";
            this.ViewCurrentPin.Name = "ViewCurrentPin";
            activitybind6.Name = "BankomatsWorkflow";
            activitybind6.Path = "tryPIN";
            workflowparameterbinding8.ParameterName = "message";
            workflowparameterbinding8.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.ViewCurrentPin.ParameterBindings.Add(workflowparameterbinding8);
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity1);
            this.ifElseActivity1.Activities.Add(this.ifElseBranchActivity2);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // setStateActivity8
            // 
            this.setStateActivity8.Name = "setStateActivity8";
            this.setStateActivity8.TargetStateName = "EnterOldPin";
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.ChangeMenu);
            // 
            // setStateActivity4
            // 
            this.setStateActivity4.Name = "setStateActivity4";
            this.setStateActivity4.TargetStateName = "Final";
            // 
            // setStateActivity5
            // 
            this.setStateActivity5.Name = "setStateActivity5";
            this.setStateActivity5.TargetStateName = "Deposit";
            // 
            // codeActivity8
            // 
            this.codeActivity8.Name = "codeActivity8";
            this.codeActivity8.ExecuteCode += new System.EventHandler(this.ChangeMenu);
            // 
            // setStateActivity7
            // 
            this.setStateActivity7.Name = "setStateActivity7";
            this.setStateActivity7.TargetStateName = "Withdrawal";
            // 
            // codeActivity7
            // 
            this.codeActivity7.Name = "codeActivity7";
            this.codeActivity7.ExecuteCode += new System.EventHandler(this.ChangeMenu);
            // 
            // setStateActivity6
            // 
            this.setStateActivity6.Name = "setStateActivity6";
            this.setStateActivity6.TargetStateName = "ViewBalance";
            // 
            // codeActivity5
            // 
            this.codeActivity5.Name = "codeActivity5";
            this.codeActivity5.ExecuteCode += new System.EventHandler(this.ChangeMenu);
            // 
            // ifElseBranchActivity13
            // 
            this.ifElseBranchActivity13.Activities.Add(this.callExternalMethodActivity7);
            this.ifElseBranchActivity13.Name = "ifElseBranchActivity13";
            // 
            // ifElseBranchActivity12
            // 
            this.ifElseBranchActivity12.Activities.Add(this.callExternalMethodActivity12);
            this.ifElseBranchActivity12.Activities.Add(this.codeActivity2);
            this.ifElseBranchActivity12.Activities.Add(this.callExternalMethodActivity11);
            this.ifElseBranchActivity12.Activities.Add(this.setStateActivity10);
            ruleconditionreference2.ConditionName = "NewPinLenght";
            this.ifElseBranchActivity12.Condition = ruleconditionreference2;
            this.ifElseBranchActivity12.Name = "ifElseBranchActivity12";
            // 
            // ifElseBranchActivity11
            // 
            this.ifElseBranchActivity11.Activities.Add(this.callExternalMethodActivity2);
            ruleconditionreference3.ConditionName = "PinCompare";
            this.ifElseBranchActivity11.Condition = ruleconditionreference3;
            this.ifElseBranchActivity11.Name = "ifElseBranchActivity11";
            // 
            // ifElseBranchActivity10
            // 
            this.ifElseBranchActivity10.Activities.Add(this.callExternalMethodActivity3);
            ruleconditionreference4.ConditionName = "NewPinLength";
            this.ifElseBranchActivity10.Condition = ruleconditionreference4;
            this.ifElseBranchActivity10.Name = "ifElseBranchActivity10";
            // 
            // ifElseBranchActivity9
            // 
            this.ifElseBranchActivity9.Activities.Add(this.setStateActivity9);
            this.ifElseBranchActivity9.Activities.Add(this.callExternalMethodActivity5);
            ruleconditionreference5.ConditionName = "NewPinCompare";
            this.ifElseBranchActivity9.Condition = ruleconditionreference5;
            this.ifElseBranchActivity9.Name = "ifElseBranchActivity9";
            // 
            // ifElseBranchActivity6
            // 
            this.ifElseBranchActivity6.Activities.Add(this.ViewCurrentCardNumber);
            this.ifElseBranchActivity6.Name = "ifElseBranchActivity6";
            // 
            // ifElseBranchActivity5
            // 
            this.ifElseBranchActivity5.Activities.Add(this.SetSelectLanguageState);
            ruleconditionreference6.ConditionName = "IsFullCardNumber";
            this.ifElseBranchActivity5.Condition = ruleconditionreference6;
            this.ifElseBranchActivity5.Name = "ifElseBranchActivity5";
            // 
            // ifElseBranchActivity8
            // 
            this.ifElseBranchActivity8.Activities.Add(this.setStateActivity1);
            ruleconditionreference7.ConditionName = "IsAction2";
            this.ifElseBranchActivity8.Condition = ruleconditionreference7;
            this.ifElseBranchActivity8.Name = "ifElseBranchActivity8";
            // 
            // ifElseBranchActivity7
            // 
            this.ifElseBranchActivity7.Activities.Add(this.ExitFromBalance);
            ruleconditionreference8.ConditionName = "IsAction1";
            this.ifElseBranchActivity7.Condition = ruleconditionreference8;
            this.ifElseBranchActivity7.Name = "ifElseBranchActivity7";
            // 
            // ifElseBranchActivity4
            // 
            this.ifElseBranchActivity4.Activities.Add(this.ViewCurrentPin);
            this.ifElseBranchActivity4.Name = "ifElseBranchActivity4";
            // 
            // ifElseBranchActivity3
            // 
            this.ifElseBranchActivity3.Activities.Add(this.ifElseActivity1);
            ruleconditionreference9.ConditionName = "IsFullPin";
            this.ifElseBranchActivity3.Condition = ruleconditionreference9;
            this.ifElseBranchActivity3.Name = "ifElseBranchActivity3";
            // 
            // cancellationHandlerActivity1
            // 
            this.cancellationHandlerActivity1.Name = "cancellationHandlerActivity1";
            ruleconditionreference10.ConditionName = "IsAction5";
            // 
            // compensatableSequenceActivity5
            // 
            this.compensatableSequenceActivity5.Activities.Add(this.codeActivity1);
            this.compensatableSequenceActivity5.Activities.Add(this.setStateActivity8);
            this.compensatableSequenceActivity5.Name = "compensatableSequenceActivity5";
            this.compensatableSequenceActivity5.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference10);
            ruleconditionreference11.ConditionName = "IsAction4";
            // 
            // compensatableSequenceActivity4
            // 
            this.compensatableSequenceActivity4.Activities.Add(this.setStateActivity4);
            this.compensatableSequenceActivity4.Name = "compensatableSequenceActivity4";
            this.compensatableSequenceActivity4.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference11);
            ruleconditionreference12.ConditionName = "IsAction3";
            // 
            // compensatableSequenceActivity3
            // 
            this.compensatableSequenceActivity3.Activities.Add(this.codeActivity8);
            this.compensatableSequenceActivity3.Activities.Add(this.setStateActivity5);
            this.compensatableSequenceActivity3.Name = "compensatableSequenceActivity3";
            this.compensatableSequenceActivity3.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference12);
            ruleconditionreference13.ConditionName = "IsAction2";
            // 
            // compensatableSequenceActivity2
            // 
            this.compensatableSequenceActivity2.Activities.Add(this.codeActivity7);
            this.compensatableSequenceActivity2.Activities.Add(this.setStateActivity7);
            this.compensatableSequenceActivity2.Name = "compensatableSequenceActivity2";
            this.compensatableSequenceActivity2.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference13);
            ruleconditionreference14.ConditionName = "IsAction1";
            // 
            // compensatableSequenceActivity1
            // 
            this.compensatableSequenceActivity1.Activities.Add(this.codeActivity5);
            this.compensatableSequenceActivity1.Activities.Add(this.setStateActivity6);
            this.compensatableSequenceActivity1.Name = "compensatableSequenceActivity1";
            this.compensatableSequenceActivity1.SetValue(System.Workflow.Activities.ConditionedActivityGroup.WhenConditionProperty, ruleconditionreference14);
            // 
            // ifElseActivity5
            // 
            this.ifElseActivity5.Activities.Add(this.ifElseBranchActivity12);
            this.ifElseActivity5.Activities.Add(this.ifElseBranchActivity13);
            this.ifElseActivity5.Name = "ifElseActivity5";
            // 
            // handleExternalEventActivity3
            // 
            this.handleExternalEventActivity3.EventName = "GetNewNum";
            this.handleExternalEventActivity3.InterfaceType = typeof(Interfaces.IFormService);
            this.handleExternalEventActivity3.Name = "handleExternalEventActivity3";
            this.handleExternalEventActivity3.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.handleExternalEventActivity3_Invoked);
            // 
            // callExternalMethodActivity6
            // 
            this.callExternalMethodActivity6.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity6.MethodName = "NewPinCodeInvite";
            this.callExternalMethodActivity6.Name = "callExternalMethodActivity6";
            // 
            // ifElseActivity4
            // 
            this.ifElseActivity4.Activities.Add(this.ifElseBranchActivity9);
            this.ifElseActivity4.Activities.Add(this.ifElseBranchActivity10);
            this.ifElseActivity4.Activities.Add(this.ifElseBranchActivity11);
            this.ifElseActivity4.Name = "ifElseActivity4";
            // 
            // handleExternalEventActivity2
            // 
            this.handleExternalEventActivity2.EventName = "GetNewNum";
            this.handleExternalEventActivity2.InterfaceType = typeof(Interfaces.IFormService);
            this.handleExternalEventActivity2.Name = "handleExternalEventActivity2";
            this.handleExternalEventActivity2.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.handleExternalEventActivity2_Invoked);
            // 
            // callExternalMethodActivity4
            // 
            this.callExternalMethodActivity4.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity4.MethodName = "SendBackMessageLine";
            this.callExternalMethodActivity4.Name = "callExternalMethodActivity4";
            workflowparameterbinding9.ParameterName = "message";
            workflowparameterbinding9.Value = "\"VVedite Starij PIN\"";
            this.callExternalMethodActivity4.ParameterBindings.Add(workflowparameterbinding9);
            // 
            // callExternalMethodActivity10
            // 
            this.callExternalMethodActivity10.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity10.MethodName = "SendBackMessageLine";
            this.callExternalMethodActivity10.Name = "callExternalMethodActivity10";
            workflowparameterbinding10.ParameterName = "message";
            workflowparameterbinding10.Value = "\"я деписоти \"";
            this.callExternalMethodActivity10.ParameterBindings.Add(workflowparameterbinding10);
            // 
            // callExternalMethodActivity8
            // 
            this.callExternalMethodActivity8.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity8.MethodName = "SendBackMessageLine";
            this.callExternalMethodActivity8.Name = "callExternalMethodActivity8";
            workflowparameterbinding11.ParameterName = "message";
            workflowparameterbinding11.Value = "\"WidtDraw\"";
            this.callExternalMethodActivity8.ParameterBindings.Add(workflowparameterbinding11);
            // 
            // ReadCardIfElse
            // 
            this.ReadCardIfElse.Activities.Add(this.ifElseBranchActivity5);
            this.ReadCardIfElse.Activities.Add(this.ifElseBranchActivity6);
            this.ReadCardIfElse.Name = "ReadCardIfElse";
            // 
            // ReadCardNumber
            // 
            this.ReadCardNumber.EventName = "GetNewNum";
            this.ReadCardNumber.InterfaceType = typeof(Interfaces.IFormService);
            this.ReadCardNumber.Name = "ReadCardNumber";
            this.ReadCardNumber.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.GetInputCardNumber);
            // 
            // DisplayWelcomeMessage
            // 
            this.DisplayWelcomeMessage.InterfaceType = typeof(Interfaces.IFormService);
            this.DisplayWelcomeMessage.MethodName = "WelcomeMessage";
            this.DisplayWelcomeMessage.Name = "DisplayWelcomeMessage";
            // 
            // InitCode
            // 
            this.InitCode.Name = "InitCode";
            this.InitCode.ExecuteCode += new System.EventHandler(this.WorkFlowInit);
            // 
            // ifElseActivity3
            // 
            this.ifElseActivity3.Activities.Add(this.ifElseBranchActivity7);
            this.ifElseActivity3.Activities.Add(this.ifElseBranchActivity8);
            this.ifElseActivity3.Name = "ifElseActivity3";
            // 
            // handleExternalEventActivity1
            // 
            this.handleExternalEventActivity1.EventName = "GetNewAction";
            this.handleExternalEventActivity1.InterfaceType = typeof(Interfaces.IFormService);
            this.handleExternalEventActivity1.Name = "handleExternalEventActivity1";
            activitybind7.Name = "BankomatsWorkflow";
            activitybind7.Path = "buffer";
            workflowparameterbinding12.ParameterName = "e";
            workflowparameterbinding12.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            this.handleExternalEventActivity1.ParameterBindings.Add(workflowparameterbinding12);
            // 
            // callExternalMethodActivity9
            // 
            this.callExternalMethodActivity9.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity9.MethodName = "ViewBalance";
            this.callExternalMethodActivity9.Name = "callExternalMethodActivity9";
            activitybind8.Name = "BankomatsWorkflow";
            activitybind8.Path = "CurrentAvailableBalance";
            workflowparameterbinding13.ParameterName = "accountAvailableBalance";
            workflowparameterbinding13.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            activitybind9.Name = "BankomatsWorkflow";
            activitybind9.Path = "CurrentTotalBalance";
            workflowparameterbinding14.ParameterName = "accountTotalBalance";
            workflowparameterbinding14.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            this.callExternalMethodActivity9.ParameterBindings.Add(workflowparameterbinding13);
            this.callExternalMethodActivity9.ParameterBindings.Add(workflowparameterbinding14);
            // 
            // ifElseActivity2
            // 
            this.ifElseActivity2.Activities.Add(this.ifElseBranchActivity3);
            this.ifElseActivity2.Activities.Add(this.ifElseBranchActivity4);
            this.ifElseActivity2.Name = "ifElseActivity2";
            // 
            // GetPinHandle
            // 
            this.GetPinHandle.EventName = "GetNewNum";
            this.GetPinHandle.InterfaceType = typeof(Interfaces.IFormService);
            this.GetPinHandle.Name = "GetPinHandle";
            this.GetPinHandle.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.GetInputPin);
            // 
            // callExternalMethodActivity1
            // 
            this.callExternalMethodActivity1.InterfaceType = typeof(Interfaces.IFormService);
            this.callExternalMethodActivity1.MethodName = "DisplayAuthMenu";
            this.callExternalMethodActivity1.Name = "callExternalMethodActivity1";
            // 
            // setStateActivity2
            // 
            this.setStateActivity2.Name = "setStateActivity2";
            this.setStateActivity2.TargetStateName = "EnterCard";
            // 
            // conditionedActivityGroup1
            // 
            this.conditionedActivityGroup1.Activities.Add(this.compensatableSequenceActivity1);
            this.conditionedActivityGroup1.Activities.Add(this.compensatableSequenceActivity2);
            this.conditionedActivityGroup1.Activities.Add(this.compensatableSequenceActivity3);
            this.conditionedActivityGroup1.Activities.Add(this.compensatableSequenceActivity4);
            this.conditionedActivityGroup1.Activities.Add(this.compensatableSequenceActivity5);
            this.conditionedActivityGroup1.Activities.Add(this.cancellationHandlerActivity1);
            this.conditionedActivityGroup1.Name = "conditionedActivityGroup1";
            ruleconditionreference15.ConditionName = "IsValidMenuAction";
            this.conditionedActivityGroup1.UntilCondition = ruleconditionreference15;
            // 
            // GetActionToDo
            // 
            this.GetActionToDo.EventName = "GetNewAction";
            this.GetActionToDo.InterfaceType = typeof(Interfaces.IFormService);
            this.GetActionToDo.Name = "GetActionToDo";
            activitybind10.Name = "BankomatsWorkflow";
            activitybind10.Path = "buffer";
            workflowparameterbinding15.ParameterName = "e";
            workflowparameterbinding15.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
            this.GetActionToDo.ParameterBindings.Add(workflowparameterbinding15);
            // 
            // ViewMenuText
            // 
            this.ViewMenuText.InterfaceType = typeof(Interfaces.IFormService);
            this.ViewMenuText.MethodName = "DisplayMenu";
            this.ViewMenuText.Name = "ViewMenuText";
            // 
            // SetAuthState
            // 
            this.SetAuthState.Name = "SetAuthState";
            this.SetAuthState.TargetStateName = "Authenticate";
            // 
            // GetLanguageHandle
            // 
            this.GetLanguageHandle.EventName = "GetNewAction";
            this.GetLanguageHandle.InterfaceType = typeof(Interfaces.IFormService);
            this.GetLanguageHandle.Name = "GetLanguageHandle";
            // 
            // ViewLanguageMenu
            // 
            this.ViewLanguageMenu.InterfaceType = typeof(Interfaces.IFormService);
            this.ViewLanguageMenu.MethodName = "DisplayLanguage";
            this.ViewLanguageMenu.Name = "ViewLanguageMenu";
            // 
            // eventDrivenActivity2
            // 
            this.eventDrivenActivity2.Activities.Add(this.handleExternalEventActivity3);
            this.eventDrivenActivity2.Activities.Add(this.ifElseActivity5);
            this.eventDrivenActivity2.Name = "eventDrivenActivity2";
            // 
            // stateInitializationActivity3
            // 
            this.stateInitializationActivity3.Activities.Add(this.callExternalMethodActivity6);
            this.stateInitializationActivity3.Name = "stateInitializationActivity3";
            // 
            // eventDrivenActivity1
            // 
            this.eventDrivenActivity1.Activities.Add(this.handleExternalEventActivity2);
            this.eventDrivenActivity1.Activities.Add(this.ifElseActivity4);
            this.eventDrivenActivity1.Name = "eventDrivenActivity1";
            // 
            // stateInitializationActivity2
            // 
            this.stateInitializationActivity2.Activities.Add(this.callExternalMethodActivity4);
            this.stateInitializationActivity2.Name = "stateInitializationActivity2";
            // 
            // handleExternalEventActivity5
            // 
            this.handleExternalEventActivity5.EventName = "GetNewNum";
            this.handleExternalEventActivity5.InterfaceType = typeof(Interfaces.IFormService);
            this.handleExternalEventActivity5.Name = "handleExternalEventActivity5";
            // 
            // handleExternalEventActivity6
            // 
            this.handleExternalEventActivity6.EventName = "GetNewAction";
            this.handleExternalEventActivity6.InterfaceType = typeof(Interfaces.IFormService);
            this.handleExternalEventActivity6.Name = "handleExternalEventActivity6";
            // 
            // stateInitializationActivity7
            // 
            this.stateInitializationActivity7.Activities.Add(this.callExternalMethodActivity10);
            this.stateInitializationActivity7.Name = "stateInitializationActivity7";
            // 
            // stateInitializationActivity5
            // 
            this.stateInitializationActivity5.Activities.Add(this.callExternalMethodActivity8);
            this.stateInitializationActivity5.Name = "stateInitializationActivity5";
            // 
            // EnterCardEvent
            // 
            this.EnterCardEvent.Activities.Add(this.ReadCardNumber);
            this.EnterCardEvent.Activities.Add(this.ReadCardIfElse);
            this.EnterCardEvent.Name = "EnterCardEvent";
            // 
            // Init
            // 
            this.Init.Activities.Add(this.InitCode);
            this.Init.Activities.Add(this.DisplayWelcomeMessage);
            this.Init.Name = "Init";
            // 
            // MenuOrExit
            // 
            this.MenuOrExit.Activities.Add(this.handleExternalEventActivity1);
            this.MenuOrExit.Activities.Add(this.ifElseActivity3);
            this.MenuOrExit.Name = "MenuOrExit";
            // 
            // InitBalace
            // 
            this.InitBalace.Activities.Add(this.callExternalMethodActivity9);
            this.InitBalace.Name = "InitBalace";
            // 
            // GetPin
            // 
            this.GetPin.Activities.Add(this.GetPinHandle);
            this.GetPin.Activities.Add(this.ifElseActivity2);
            this.GetPin.Name = "GetPin";
            // 
            // InitAuth
            // 
            this.InitAuth.Activities.Add(this.callExternalMethodActivity1);
            this.InitAuth.Name = "InitAuth";
            // 
            // stateInitializationActivity1
            // 
            this.stateInitializationActivity1.Activities.Add(this.setStateActivity2);
            this.stateInitializationActivity1.Name = "stateInitializationActivity1";
            // 
            // SelectActionToDo
            // 
            this.SelectActionToDo.Activities.Add(this.GetActionToDo);
            this.SelectActionToDo.Activities.Add(this.conditionedActivityGroup1);
            this.SelectActionToDo.Name = "SelectActionToDo";
            // 
            // InitMenu
            // 
            this.InitMenu.Activities.Add(this.ViewMenuText);
            this.InitMenu.Name = "InitMenu";
            // 
            // GetLanguage
            // 
            this.GetLanguage.Activities.Add(this.GetLanguageHandle);
            this.GetLanguage.Activities.Add(this.SetAuthState);
            this.GetLanguage.Name = "GetLanguage";
            // 
            // InitLanguage
            // 
            this.InitLanguage.Activities.Add(this.ViewLanguageMenu);
            this.InitLanguage.Name = "InitLanguage";
            // 
            // EnterNewPin
            // 
            this.EnterNewPin.Activities.Add(this.stateInitializationActivity3);
            this.EnterNewPin.Activities.Add(this.eventDrivenActivity2);
            this.EnterNewPin.Name = "EnterNewPin";
            // 
            // EnterOldPin
            // 
            this.EnterOldPin.Activities.Add(this.stateInitializationActivity2);
            this.EnterOldPin.Activities.Add(this.eventDrivenActivity1);
            this.EnterOldPin.Name = "EnterOldPin";
            // 
            // NumHandler
            // 
            this.NumHandler.Activities.Add(this.handleExternalEventActivity5);
            this.NumHandler.Name = "NumHandler";
            // 
            // ActionHandler
            // 
            this.ActionHandler.Activities.Add(this.handleExternalEventActivity6);
            this.ActionHandler.Name = "ActionHandler";
            // 
            // Deposit
            // 
            this.Deposit.Activities.Add(this.stateInitializationActivity7);
            this.Deposit.Name = "Deposit";
            // 
            // Withdrawal
            // 
            this.Withdrawal.Activities.Add(this.stateInitializationActivity5);
            this.Withdrawal.Name = "Withdrawal";
            // 
            // EnterCard
            // 
            this.EnterCard.Activities.Add(this.Init);
            this.EnterCard.Activities.Add(this.EnterCardEvent);
            this.EnterCard.Name = "EnterCard";
            // 
            // ViewBalance
            // 
            this.ViewBalance.Activities.Add(this.InitBalace);
            this.ViewBalance.Activities.Add(this.MenuOrExit);
            this.ViewBalance.Name = "ViewBalance";
            // 
            // Authenticate
            // 
            this.Authenticate.Activities.Add(this.InitAuth);
            this.Authenticate.Activities.Add(this.GetPin);
            this.Authenticate.Name = "Authenticate";
            // 
            // Final
            // 
            this.Final.Activities.Add(this.stateInitializationActivity1);
            this.Final.Name = "Final";
            // 
            // Menu
            // 
            this.Menu.Activities.Add(this.InitMenu);
            this.Menu.Activities.Add(this.SelectActionToDo);
            this.Menu.Name = "Menu";
            // 
            // SelectLanguage
            // 
            this.SelectLanguage.Activities.Add(this.InitLanguage);
            this.SelectLanguage.Activities.Add(this.GetLanguage);
            this.SelectLanguage.Name = "SelectLanguage";
            // 
            // BankomatsWorkflow
            // 
            this.Activities.Add(this.SelectLanguage);
            this.Activities.Add(this.Menu);
            this.Activities.Add(this.Final);
            this.Activities.Add(this.Authenticate);
            this.Activities.Add(this.ViewBalance);
            this.Activities.Add(this.EnterCard);
            this.Activities.Add(this.Withdrawal);
            this.Activities.Add(this.Deposit);
            this.Activities.Add(this.ActionHandler);
            this.Activities.Add(this.NumHandler);
            this.Activities.Add(this.EnterOldPin);
            this.Activities.Add(this.EnterNewPin);
            this.CompletedStateName = null;
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "EnterCard";
            this.Name = "BankomatsWorkflow";
            this.CanModifyActivities = false;

        }

        #endregion

        private CallExternalMethodActivity callExternalMethodActivity12;
        private SetStateActivity setStateActivity10;
        private CallExternalMethodActivity callExternalMethodActivity11;
        private CallExternalMethodActivity callExternalMethodActivity4;
        private CallExternalMethodActivity callExternalMethodActivity5;
        private CallExternalMethodActivity callExternalMethodActivity6;
        private HandleExternalEventActivity handleExternalEventActivity3;
        private EventDrivenActivity eventDrivenActivity2;
        private IfElseBranchActivity ifElseBranchActivity13;
        private IfElseBranchActivity ifElseBranchActivity12;
        private IfElseActivity ifElseActivity5;
        private CallExternalMethodActivity callExternalMethodActivity7;
        private CodeActivity codeActivity2;
        private SetStateActivity setStateActivity9;
        private StateActivity EnterNewPin;
        private StateInitializationActivity stateInitializationActivity3;
        private IfElseBranchActivity ifElseBranchActivity11;
        private CallExternalMethodActivity callExternalMethodActivity2;
        private CallExternalMethodActivity callExternalMethodActivity3;
        private StateActivity EnterOldPin;
        private CompensatableSequenceActivity compensatableSequenceActivity5;
        private SetStateActivity setStateActivity8;
        private CodeActivity codeActivity1;
        private StateInitializationActivity stateInitializationActivity2;
        private EventDrivenActivity eventDrivenActivity1;
        private IfElseBranchActivity ifElseBranchActivity10;
        private IfElseBranchActivity ifElseBranchActivity9;
        private IfElseActivity ifElseActivity4;
        private HandleExternalEventActivity handleExternalEventActivity2;
        private SetStateActivity setStateActivity3;
        private IfElseBranchActivity ifElseBranchActivity8;
        private IfElseBranchActivity ifElseBranchActivity7;
        private IfElseActivity ifElseActivity3;
        private HandleExternalEventActivity handleExternalEventActivity1;
        private EventDrivenActivity MenuOrExit;
        private SetStateActivity setStateActivity1;
        private SetStateActivity ExitFromBalance;
        private StateInitializationActivity stateInitializationActivity1;
        private SetStateActivity setStateActivity2;
        private CodeActivity codeActivity8;
        private CodeActivity codeActivity7;
        private HandleExternalEventActivity handleExternalEventActivity6;
        private EventDrivenActivity ActionHandler;
        private HandleExternalEventActivity handleExternalEventActivity5;
        private EventDrivenActivity NumHandler;
        private CancellationHandlerActivity cancellationHandlerActivity1;
        private CodeActivity codeActivity5;
        private CompensatableSequenceActivity compensatableSequenceActivity4;
        private CompensatableSequenceActivity compensatableSequenceActivity3;
        private CompensatableSequenceActivity compensatableSequenceActivity2;
        private CompensatableSequenceActivity compensatableSequenceActivity1;
        private ConditionedActivityGroup conditionedActivityGroup1;
        private SetStateActivity setStateActivity4;
        private SetStateActivity setStateActivity5;
        private SetStateActivity setStateActivity7;
        private SetStateActivity setStateActivity6;
        private StateActivity Withdrawal;
        private StateActivity Deposit;
        private StateInitializationActivity stateInitializationActivity7;
        private StateInitializationActivity stateInitializationActivity5;
        private StateInitializationActivity InitBalace;
        private CallExternalMethodActivity callExternalMethodActivity10;
        private CallExternalMethodActivity callExternalMethodActivity8;
        private CallExternalMethodActivity callExternalMethodActivity9;
        private HandleExternalEventActivity GetActionToDo;
        private EventDrivenActivity SelectActionToDo;
        private CallExternalMethodActivity ViewCurrentPin;
        private CallExternalMethodActivity ViewMenuText;
        private StateInitializationActivity InitMenu;
        private CallExternalMethodActivity ViewCurrentCardNumber;
        private SetStateActivity SetSelectLanguageState;
        private CodeActivity InitCode;
        private CallExternalMethodActivity DisplayWelcomeMessage;
        private StateInitializationActivity Init;
        private StateActivity EnterCard;
        private IfElseBranchActivity ifElseBranchActivity6;
        private IfElseBranchActivity ifElseBranchActivity5;
        private IfElseActivity ReadCardIfElse;
        private HandleExternalEventActivity ReadCardNumber;
        private EventDrivenActivity EnterCardEvent;
        private StateActivity ViewBalance;
        private IfElseBranchActivity ifElseBranchActivity4;
        private IfElseBranchActivity ifElseBranchActivity3;
        private IfElseActivity ifElseActivity2;
        private CallExternalMethodActivity AuthFailed;
        private SetStateActivity SetMenuState;
        private IfElseBranchActivity ifElseBranchActivity2;
        private IfElseBranchActivity ifElseBranchActivity1;
        private IfElseActivity ifElseActivity1;
        private HandleExternalEventActivity GetPinHandle;
        private EventDrivenActivity GetPin;
        private StateActivity Final;
        private StateActivity Menu;
        private HandleExternalEventActivity GetLanguageHandle;
        private EventDrivenActivity GetLanguage;
        private StateInitializationActivity InitLanguage;
        private StateActivity Authenticate;
        private CallExternalMethodActivity callExternalMethodActivity1;
        private StateInitializationActivity InitAuth;
        private CallExternalMethodActivity ViewLanguageMenu;
        private SetStateActivity SetAuthState;
        private StateActivity SelectLanguage;
















































































































































































































    }
}
