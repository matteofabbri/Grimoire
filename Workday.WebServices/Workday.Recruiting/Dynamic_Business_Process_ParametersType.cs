using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Dynamic_Business_Process_ParametersType : INotifyPropertyChanged
	{
		private Workflow_StepObjectType itemField;

		private ItemChoiceType6 itemElementNameField;

		private Business_Process_Comment_DataType[] comment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Disposition_Step_Reference", typeof(Workflow_StepObjectType), Order = 0), XmlElement("Next_Step_Reference", typeof(Workflow_StepObjectType), Order = 0)]
		public Workflow_StepObjectType Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1), XmlIgnore]
		public ItemChoiceType6 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement("Comment_Data", Order = 2)]
		public Business_Process_Comment_DataType[] Comment_Data
		{
			get
			{
				return this.comment_DataField;
			}
			set
			{
				this.comment_DataField = value;
				this.RaisePropertyChanged("Comment_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
