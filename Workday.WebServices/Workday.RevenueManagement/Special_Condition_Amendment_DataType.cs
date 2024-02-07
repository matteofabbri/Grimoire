using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Special_Condition_Amendment_DataType : INotifyPropertyChanged
	{
		private Special_ConditionObjectType special_Condition_ReferenceField;

		private string special_Condition_Reference_IDField;

		private Special_Condition_TypeObjectType special_Condition_Type_ReferenceField;

		private string special_Condition_CommentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Special_ConditionObjectType Special_Condition_Reference
		{
			get
			{
				return this.special_Condition_ReferenceField;
			}
			set
			{
				this.special_Condition_ReferenceField = value;
				this.RaisePropertyChanged("Special_Condition_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Special_Condition_Reference_ID
		{
			get
			{
				return this.special_Condition_Reference_IDField;
			}
			set
			{
				this.special_Condition_Reference_IDField = value;
				this.RaisePropertyChanged("Special_Condition_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Special_Condition_TypeObjectType Special_Condition_Type_Reference
		{
			get
			{
				return this.special_Condition_Type_ReferenceField;
			}
			set
			{
				this.special_Condition_Type_ReferenceField = value;
				this.RaisePropertyChanged("Special_Condition_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Special_Condition_Comment
		{
			get
			{
				return this.special_Condition_CommentField;
			}
			set
			{
				this.special_Condition_CommentField = value;
				this.RaisePropertyChanged("Special_Condition_Comment");
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
