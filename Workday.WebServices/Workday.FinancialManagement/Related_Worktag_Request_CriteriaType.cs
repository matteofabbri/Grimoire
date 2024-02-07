using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Related_Worktag_Request_CriteriaType : INotifyPropertyChanged
	{
		private Worktag_Type_Configuration_SetObjectType[] worktag_Type_Configuration_Set_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worktag_Type_Configuration_Set_Reference", Order = 0)]
		public Worktag_Type_Configuration_SetObjectType[] Worktag_Type_Configuration_Set_Reference
		{
			get
			{
				return this.worktag_Type_Configuration_Set_ReferenceField;
			}
			set
			{
				this.worktag_Type_Configuration_Set_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Type_Configuration_Set_Reference");
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
