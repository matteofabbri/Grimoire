using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Instructor_Role_Assignment_DataType : INotifyPropertyChanged
	{
		private Assignable_RoleObjectType assignable_Role_ReferenceField;

		private bool remove_All_Existing_AssigneesField;

		private bool remove_All_Existing_AssigneesFieldSpecified;

		private RoleeObjectType[] assignees_to_Add_ReferenceField;

		private Rolee_SelectorObjectType[] assignees_to_Remove_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Assignable_RoleObjectType Assignable_Role_Reference
		{
			get
			{
				return this.assignable_Role_ReferenceField;
			}
			set
			{
				this.assignable_Role_ReferenceField = value;
				this.RaisePropertyChanged("Assignable_Role_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_All_Existing_Assignees
		{
			get
			{
				return this.remove_All_Existing_AssigneesField;
			}
			set
			{
				this.remove_All_Existing_AssigneesField = value;
				this.RaisePropertyChanged("Remove_All_Existing_Assignees");
			}
		}

		[XmlIgnore]
		public bool Remove_All_Existing_AssigneesSpecified
		{
			get
			{
				return this.remove_All_Existing_AssigneesFieldSpecified;
			}
			set
			{
				this.remove_All_Existing_AssigneesFieldSpecified = value;
				this.RaisePropertyChanged("Remove_All_Existing_AssigneesSpecified");
			}
		}

		[XmlElement("Assignees_to_Add_Reference", Order = 2)]
		public RoleeObjectType[] Assignees_to_Add_Reference
		{
			get
			{
				return this.assignees_to_Add_ReferenceField;
			}
			set
			{
				this.assignees_to_Add_ReferenceField = value;
				this.RaisePropertyChanged("Assignees_to_Add_Reference");
			}
		}

		[XmlElement("Assignees_to_Remove_Reference", Order = 3)]
		public Rolee_SelectorObjectType[] Assignees_to_Remove_Reference
		{
			get
			{
				return this.assignees_to_Remove_ReferenceField;
			}
			set
			{
				this.assignees_to_Remove_ReferenceField = value;
				this.RaisePropertyChanged("Assignees_to_Remove_Reference");
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
