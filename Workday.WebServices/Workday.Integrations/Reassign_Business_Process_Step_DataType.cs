using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Reassign_Business_Process_Step_DataType : INotifyPropertyChanged
	{
		private RoleObjectType reassign_To_ReferenceField;

		private RoleObjectType reassign_From_ReferenceField;

		private string reasonField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RoleObjectType Reassign_To_Reference
		{
			get
			{
				return this.reassign_To_ReferenceField;
			}
			set
			{
				this.reassign_To_ReferenceField = value;
				this.RaisePropertyChanged("Reassign_To_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public RoleObjectType Reassign_From_Reference
		{
			get
			{
				return this.reassign_From_ReferenceField;
			}
			set
			{
				this.reassign_From_ReferenceField = value;
				this.RaisePropertyChanged("Reassign_From_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Reason
		{
			get
			{
				return this.reasonField;
			}
			set
			{
				this.reasonField = value;
				this.RaisePropertyChanged("Reason");
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
